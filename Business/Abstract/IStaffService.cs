using Entities.Concrete;

namespace Business.Abstract;

public interface IStaffService
{
    List<Staff> GetAll();
    List<Staff> GetByFullName(string firstName, string lastName);
    Staff GetById(int id);
    void Add(Staff staff);
    void Update(Staff staff);
    void Delete(int id);
}
