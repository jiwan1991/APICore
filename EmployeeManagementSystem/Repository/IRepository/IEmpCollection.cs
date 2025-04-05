using System;
using System.Collections;
using System.Collections.Generic;


namespace EmployeeManagementSystem.Repository.IRepository
{
    public interface IEmpCollection<T> where T:class
    {
       public  List<T> GetAll();
        public T GetbyId(int id);
        public void ADD(T item);
        public void Remove(int id);
        public void Update(T repoItem, T entity);

    }
}
