using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC8amDragon_16092021.Models
{
    public class Empdept
    {
        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}