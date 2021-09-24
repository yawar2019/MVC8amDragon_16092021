using MVC8amDragon_16092021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amDragon_16092021.Controllers
{
    public class NewController : Controller
    {
        // GET:hello
       public int LuckyNumber()
        {

            return 17;
        }

        public string BestSuperHero()
        {
            return "Dad";
        }

        public string getLuckyNumber(int? id)//new/getLuckyNumber/11
        {

            return "My LuckyNumber is "+id;
        }

        public string getLuckyNumber2(int? id,string name)//new/getLuckyNumber2/11?name=james
        {

            return "My LuckyNumber is " + id+" and name is "+name;
        }
        public ActionResult SendDataToView()
        {

            ViewBag.LastName = "shetty";

            return View();
        }

        public ActionResult getEmployeeData()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Sunitha";
            emp.EmpSalary = 1202020;

            ViewBag.Data = emp;

            return View();
        }

        public ActionResult getListEmployeeData()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Sunitha";
            emp.EmpSalary = 1202020;

            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Om Prakash";
            emp1.EmpSalary = 2202020;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sabir";
            emp2.EmpSalary = 13202020;//sfsdfsd

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            ViewBag.info = listEmp;

            return View();
        }
        public ActionResult sendDatausingViewModel()
        {
             
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Sunitha";
            emp.EmpSalary = 1202020;

        //    object model = emp;
            return View(emp);

        }

        public ViewResult sendDatausingViewModel2()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            List<DepartmentModel> listDept = new List<DepartmentModel>();

            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Sunitha";
            emp.EmpSalary = 1202020;

            EmployeeModel emp1 = new Models.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Om Prakash";
            emp1.EmpSalary = 2202020;

            EmployeeModel emp2 = new Models.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sabir";
            emp2.EmpSalary = 13202020;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Network";

            listDept.Add(dept);
            listDept.Add(dept1);

            Empdept obj = new Empdept();
            obj.emp = listEmp;
            obj.dept = listDept;


            //    object model = obj;
            return View(obj);

        }

        public ViewResult getMeView(int? id)
        {
            return View();
        }
        public RedirectResult GoToGoogle()
        {
            return Redirect("http://www.google.com?id=1");
        }
        public RedirectResult GoTogetMeView()
        {
            return Redirect("~/New/getMeView/1");
        }

    }
}