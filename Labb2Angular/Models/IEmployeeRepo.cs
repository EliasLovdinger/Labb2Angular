namespace Labb2Angular.Models
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetAll { get; }
        
        Employee GetById(int id);

        Employee Add(Employee employee);

        Employee Update(Employee employee);

        Employee Delete(int id);
    }
}
