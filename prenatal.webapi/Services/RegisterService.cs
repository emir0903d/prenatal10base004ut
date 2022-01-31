using AutoMapper;
using prenatal.model;
using prenatal.model.Enumerations;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class RegisterService:IRegisterService
    {
        private readonly Context _db;
        private readonly IMapper _autoMapper;
        private readonly IEmailService _email;
        private readonly IAuthenticateService _authenticate;
        public RegisterService(Context context, IMapper autoMapper, IEmailService emailService, IAuthenticateService authenticateService)
        {
            _db = context;
            _autoMapper = autoMapper;
            _email = emailService;
            _authenticate = authenticateService;

        }
        public List<User> GetDoctors()
        {
            return _autoMapper.Map<List<User>>(_db.Users.Where(x=>x.Type==UserType.Type.Doctor).ToList());
        }
        public User Register (UserRegisterRequest request)
        {
            if(_db.Users.Any(x=>x.Email == request.Email))
            {
                return null;
            }

            Users newUser = _autoMapper.Map<Users>(request);

            string _username = GenerateUsername(newUser.Name, newUser.Surname);
            string _password = GeneratePassword();

            string txt = "Hi, " + newUser.Name +
                "\n your username: " + _username +
                "\n and password: " + _password;

            _email.Send(newUser.Name, newUser.Email, txt);

            newUser.Username = _username;
            string _salt = _authenticate.GenerateSalt();
            string _hash = _authenticate.GenerateHash(_salt, _password);

            newUser.PasswordSalt = _salt;
            newUser.PasswordHash = _hash;

            _db.Users.Add(newUser);
            _db.SaveChanges();
            _db.Dispose();

            return _autoMapper.Map<User>(newUser);

        }
        public string GenerateUsername(string name, string surname)
        {
            string _username = surname.ToLower() + name.ToLower().Substring(0, 1);

            int i = 1;
            
            while (_db.Users.Where(x=>x.Username == _username).Any() == true)
            {
                if (i < name.Length)
                {
                    i++;
                    _username = surname.ToLower() + name.ToLower().Substring(0, i);
                }

                int y = 1;
                if (i == name.Length)
                {
                    _username = surname.ToLower().Substring(0, surname.Length - y) + name.ToLower().Substring(0, i);
                    y++;
                }

            }
            return _username;

        }
        public string GeneratePassword()
        {
            var options = new
            {
                RequiredLenght = 4,
                RequireNonAlphanumeric = false,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = false
            };

            int length = options.RequiredLenght;

            bool nonAlphanumeric = options.RequireNonAlphanumeric;
            bool digit = options.RequireDigit;
            bool lowercase = options.RequireLowercase;
            bool uppercase = options.RequireUppercase;

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            while (password.Length < length)
            {
                char c = (char)random.Next(32, 126);

                password.Append(c);

                if (char.IsDigit(c))
                    digit = false;
                else if (char.IsLower(c))
                    lowercase = false;
                else if (char.IsUpper(c))
                    uppercase = false;
                else if (!char.IsLetterOrDigit(c))
                    nonAlphanumeric = false;
            }

            if (nonAlphanumeric)
                password.Append((char)random.Next(33, 47));
            if (digit)
                password.Append((char)random.Next(48, 57));
            if (lowercase)
                password.Append((char)random.Next(97, 122));
            if (uppercase)
                password.Append((char)random.Next(65, 90));

            return password.ToString();
        }

    }
}
