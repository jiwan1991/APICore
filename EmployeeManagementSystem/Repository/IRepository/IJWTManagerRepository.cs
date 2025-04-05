using EmployeeManagementSystem.Autentication.Models;

namespace EmployeeManagementSystem.Repository.IRepository
{
    public interface IJWTManagerRepository
    {
        string Autenticate(User users);
    }
}
