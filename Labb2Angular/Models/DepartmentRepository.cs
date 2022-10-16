namespace Labb2Angular.Models
{
    public class DepartmentRepository : IDeparmentRepo
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Department> GetAllDepartments => _appDbContext.departments;

        public Department GetDepartmentById(int id)
        {
            return _appDbContext.departments.FirstOrDefault(a => a.DepartmentId == id);
        }
    }
}
