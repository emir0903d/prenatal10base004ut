using Microsoft.EntityFrameworkCore;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly Context _db;
        public DatabaseService(Context context)
        {
            _db = context;
        }
        public int GetUserId(string username)
        {
            return _db.Users.AsQueryable().Where(x => x.Username == username).SingleOrDefault().Id;
            
        }

        public bool HasPatientMRN(string username)
        {
            Users patient = _db.Users.Where(x => x.Username == username).SingleOrDefault();
            if (patient.HasMR == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetHasMR(string username)
        {
            Users patient = _db.Users.Where(x => x.Username == username).SingleOrDefault();
            patient.HasMR = true;
            _db.Users.Update(patient);
            _db.SaveChanges();
        }
        public void InsertMR(MedicalRecords records)
        {
            _db.MedicalRecords.Add(records);
            _db.SaveChanges();
        }
        public void InsertUser(Users user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        

        }
        public void InsertRole(Roles role)
        {
            _db.Roles.Add(role);
            _db.SaveChanges();
  
        }

        public bool IsRole(string rolename)
        {
            var query = _db.Roles.AsQueryable().Where(x => x.Name==rolename).SingleOrDefault();
            if (query != null)
            {
                return true;
            }
            return false;
        }

        public bool IsUserInRole(string username, string role)
        {
            var query = _db.UsersRoles.AsQueryable().Where(x => x.Roles.Name == role && x.Users.Username == username).SingleOrDefault();
            if (query != null)
            {
                return true;
            }
            return false;
        }

        public bool IsUsername(string username)
        {
            var query = _db.Users.AsQueryable().Where(x => x.Username == username).SingleOrDefault();
            if (query!=null)
            {
                return true;
            }
            return false;
        }

        public void InsertUserInRole(string username, string rolename)
        {
            var user = _db.Users.AsQueryable().Where(x => x.Username == username).SingleOrDefault();
            var role = _db.Roles.AsQueryable().Where(x => x.Name == rolename).SingleOrDefault();
            UsersRoles x = new UsersRoles()
            {
                UserId = user.Id,
                RoleId = role.Id,
                Change = DateTime.Now
            };        
            
            _db.UsersRoles.Add(x);
                        
            role.NumberOfUsers++;
            _db.Roles.Update(role);

            _db.SaveChanges();
       

        }

        public void DisposeConn()
        {
            _db.Dispose();
        }
    }
}
