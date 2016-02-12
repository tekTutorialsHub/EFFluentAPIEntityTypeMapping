using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace EFFlunetAPITypeMapping
{
    public class Employee
    {
        public int EmployeeCode { get; set; }
        public string Name { get; set; }

        public ContactInfo EmployeeContact { get; set; }
    }

    public class Department
    {
        public int DeptCode { get; set; }
        public string Name { get; set; }

        public decimal Budget { get; set; }
        public ContactInfo DepartmentContact { get; set; }
    }

    public class IgnoreThisTable
    {
        public int IgnoreThisTableID { get; set; }
        public string Name { get; set; }
    }


    //This is a complex type
    public class ContactInfo
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }


}
