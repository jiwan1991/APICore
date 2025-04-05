

using EmployeeManagementSystem.Entity.Models;

namespace EmployeeManagementSystem.Repository
{
    public class DataSource
    {
        public static List<Employee> employees = new List<Employee>()
        {
          new Employee{EmpID=101,EmpName="Suresh",Salery=25000,address=new Address{ city="Bangalore",state="Karnataka"} },
          new Employee{EmpID=102,EmpName="Mahesh",Salery=29000,address=new Address{ city="NorthBangalore",state="Karnataka"} },
          new Employee{EmpID=103,EmpName="Durgesh",Salery=9000,address=new Address{ city="Pune",state="Maharastra"} },
          new Employee{EmpID=104,EmpName="Bandi",Salery=56000,address=new Address{ city="Bangluru",state="Karnataka"} },
          new Employee{EmpID=105,EmpName="Kala",Salery=45000,address=new Address{ city="Mumbai",state="Maharastra"} },
          new Employee{EmpID=106,EmpName="laila",Salery=70000,address=new Address{ city="Bangalore",state="Karnataka"} },
          new Employee{EmpID=107,EmpName="Vijay",Salery=100000,address=new Address{ city="Noida",state="UP"} },
          new Employee{EmpID=108,EmpName="Sanjay",Salery=44000,address=new Address{ city="Dehradun",state="Uttrakhand"} },
          new Employee{EmpID=109,EmpName="Dipa",Salery=10000,address=new Address{ city="Bangalore",state="Karnataka"} },
          new Employee{EmpID=110,EmpName="Aditi",Salery=88000,address=new Address{ city="PremNagar",state="Uttrakhand"} },
          new Employee{EmpID=111,EmpName="Ganesh",Salery=34000,address=new Address{ city="Pune",state="Maharastra"} },
          new Employee{EmpID=112,EmpName="Lula",Salery=12000,address=new Address{ city="NewDelhi",state="Delhi"} },
          new Employee{EmpID=113,EmpName="Chamara",Salery=90000,address=new Address{ city="Indore",state="MP"} },
        };

        public static Dictionary<string, string> credentails = new Dictionary<string, string>
        {
            { "ajay", "ajay@123" },
            { "vijay", "vijay@123" }
        };
    }
}
