using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface IAuthenticateService
    {
        public User Authenticate(UserAuthenticationRequest request);
        public string GenerateSalt();
        public string GenerateHash(string salt, string password);
        public User OverridePassword(int Id, string _newPassword);
        public User GenerateUsername(int Id);
        //public string GeneratePassword();
    }
}
