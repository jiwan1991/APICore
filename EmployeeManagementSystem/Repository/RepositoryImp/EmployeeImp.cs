using EmployeeManagementSystem.Entity.Models;
using EmployeeManagementSystem.Repository.IRepository;

namespace EmployeeManagementSystem.Repository.RepositoryImp
{
    public class EmployeeImp : IEmpCollection<Employee>
    {
        public List<Employee> GetAll()
        {
            return DataSource.employees.ToList();
        }
        public Employee GetbyId(int id)
        {
            return DataSource.employees.FirstOrDefault(x => x.EmpID == id);
        }
        public void ADD(Employee item)
        {
            DataSource.employees.Add(item);
        }
        public void Remove(int id)
        {
            try
            {
                var source = DataSource.employees.FirstOrDefault(i => i.EmpID == id);
                DataSource.employees.Remove(source);
            }
            catch (Exception e) { throw e.InnerException; }
        }
           
        public void Update(Employee repoItem, Employee entity)
        {
            //Yet to implement
        }


    }
}
