namespace Labb2Angular.Models
{
    public interface IDeparmentRepo
    {
        Department GetDepartmentById(int id);

        IEnumerable<Department> GetAllDepartments { get; }
    }
}
