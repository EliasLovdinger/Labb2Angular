namespace Labb2Angular.Models
{
    public class EmployeeRepository : IEmployeeRepo
    {
        private readonly AppDbContext _appDbcontext;

        public EmployeeRepository(AppDbContext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }

        public IEnumerable<Employee> GetAll => _appDbcontext.employees;

        public Employee Add(Employee employee)
        {
            var employeeToAdd = new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                MobileNumber = employee.MobileNumber,
                Email = employee.Email,
                Gender = employee.Gender,
                Adress = employee.Adress,
                Salary = employee.Salary,
                DepartmentId = employee.DepartmentId
            };

            _appDbcontext.employees.Add(employeeToAdd);
            _appDbcontext.SaveChanges();

            return employee;
        }

        public Employee Delete(int id)
        {
            var EmployeeToDelete = _appDbcontext.employees.Find(id);
            _appDbcontext.employees.Remove(EmployeeToDelete);
            _appDbcontext.SaveChanges();

            return EmployeeToDelete;
        }

        public Employee GetById(int id)
        {
            return _appDbcontext.employees.FirstOrDefault(c => c.EmployeeId == id);
        }

        public Employee Update(Employee employee)
        {
            var EmployeeToUpdate = _appDbcontext.employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
            if (EmployeeToUpdate != null)
            {
                EmployeeToUpdate.FirstName = employee.FirstName;
                EmployeeToUpdate.LastName = employee.LastName;
                EmployeeToUpdate.MobileNumber = employee.MobileNumber;
                EmployeeToUpdate.Email = employee.Email;
                EmployeeToUpdate.Gender = employee.Gender;
                EmployeeToUpdate.Adress = employee.Adress;
                EmployeeToUpdate.Salary = employee.Salary;
                EmployeeToUpdate.DepartmentId = employee.DepartmentId;

                _appDbcontext.employees.Update(EmployeeToUpdate);
                _appDbcontext.SaveChanges();
                return EmployeeToUpdate;
            }

            return EmployeeToUpdate;
        }
    }
}
