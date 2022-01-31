using System;
using System.Collections.Generic;
using System.Text;

namespace prenatal.model.Enumerations
{
    public class UserType
    {
        public enum Type
        {
            Unknown=0,
            Admin=1,
            Doctor=2,
            Nurse=3,
            LabAssistant=4,
            Patient = 5

        }
    }
}
