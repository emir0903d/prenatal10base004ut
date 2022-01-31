using prenatal.model.Requests;
using prenatal.webapi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prenatal.webapi.Services
{
    public interface IDatabaseService
    {
        public bool IsUsername(string username);
        public int GetUserId(string username);
        public bool HasPatientMRN(string username);
        public void SetHasMR(string username);
        public void InsertMR(MedicalRecords records);
        public bool IsRole(string rolename);
        public bool IsUserInRole(string username, string role);
        public void InsertUser(Users user);
        public void InsertRole(Roles role);
        public void InsertUserInRole(string username, string role);
        public void DisposeConn();
        
    }
}
