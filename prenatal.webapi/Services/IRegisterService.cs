using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface IRegisterService
    {
        public User Register(UserRegisterRequest request);
        public string GenerateUsername(string name, string surname);
        public string GeneratePassword();
        public List<User> GetDoctors();
    }
}
