using prenatal.model.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model.Requests
{
    public class SearchUsersRequest
    {
        public string NameSurname { get; set; }
        public UserType.Type[] Type {get; set;}      
        public UserStatus.Status[] Status { get; set; }
        public int? DoctorsId { get; set; }
    
    }
}
