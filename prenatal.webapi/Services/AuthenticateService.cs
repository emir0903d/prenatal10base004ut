using AutoMapper;
using prenatal.model;
using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class AuthenticateService:IAuthenticateService
    {
        private readonly Context _db;
        private readonly IMapper _autoMapper;
        public AuthenticateService(Context context, IMapper autoMapper)
        {
            _db = context;
            _autoMapper = autoMapper;
        }
        public User GenerateUsername(int Id)
        {
            Users x = _db.Users.Find(Id);           
            string _username = x.Surname.ToLower() + x.Name.ToLower().Substring(0, 1);
            int i = 1;
            while(_db.Users.Where(x=>x.Id!=Id && x.Username == _username).Any() == true)
            {
                if (i < x.Name.Length)
                {
                    i++;
                    _username = x.Surname.ToLower() + x.Name.ToLower().Substring(0, i);
                }

                int y = 1;
                if (i == x.Name.Length)
                {
                    _username = x.Surname.ToLower().Substring(0,x.Surname.Length-y) + x.Name.ToLower().Substring(0, i);
                    y++;
                }
     
            }
            x.Username = _username;
            _db.Users.Update(x);
            _db.SaveChanges();
            _db.Dispose();

            return _autoMapper.Map<User>(x);

        }
        public User OverridePassword(int Id, string _newPassword)
        {
            string salt = GenerateSalt();
            string hash = GenerateHash(salt, _newPassword);
            Users x = _db.Users.Find(Id);
            x.PasswordSalt = salt;
            x.PasswordHash = hash;
            _db.Users.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return _autoMapper.Map<User>(x);
        }
        public User Authenticate(UserAuthenticationRequest request)
        {
            Users user = _db.Users.Where(x => x.Username == request.username).SingleOrDefault();

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, request.password);

                if (newHash == user.PasswordHash)
                {
                    return _autoMapper.Map<User>(user);
                }
            }
            return null;
        }

        public string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        //public string GeneratePassword()
        //{
        //    var options = new
        //    {
        //        RequiredLenght = 4,
        //        RequireNonAlphanumeric = false,
        //        RequireDigit = true,
        //        RequireLowercase = true,
        //        RequireUppercase = false
        //    };

        //    int length = options.RequiredLenght;

        //    bool nonAlphanumeric = options.RequireNonAlphanumeric;
        //    bool digit = options.RequireDigit;
        //    bool lowercase = options.RequireLowercase;
        //    bool uppercase = options.RequireUppercase;

        //    StringBuilder password = new StringBuilder();
        //    Random random = new Random();

        //    while (password.Length < length)
        //    {
        //        char c = (char)random.Next(32, 126);

        //        password.Append(c);

        //        if (char.IsDigit(c))
        //            digit = false;
        //        else if (char.IsLower(c))
        //            lowercase = false;
        //        else if (char.IsUpper(c))
        //            uppercase = false;
        //        else if (!char.IsLetterOrDigit(c))
        //            nonAlphanumeric = false;
        //    }

        //    if (nonAlphanumeric)
        //        password.Append((char)random.Next(33, 47));
        //    if (digit)
        //        password.Append((char)random.Next(48, 57));
        //    if (lowercase)
        //        password.Append((char)random.Next(97, 122));
        //    if (uppercase)
        //        password.Append((char)random.Next(65, 90));

        //    return password.ToString();
        //}
    }
}
