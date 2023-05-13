using Business.Abstract;
using Business.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;

namespace Business.Concrete;

public class StaffManager : IStaffService
{
    private IStaffDal _staffDal;
    StaffValidator staffValdiator = new();

    public StaffManager(IStaffDal staffDal)
    {
        _staffDal = staffDal;
    }

    public void Add(Staff staff)
    {
        ValidationResult result = staffValdiator.Validate(staff);
        if (result.IsValid)
        {
            _staffDal.Add(staff);
        }
        else
        {
            var errors = result.Errors.ToList();
            throw new ValidationException(errors);
        }
    }

    public void Delete(int id)
    {
        Staff staff = GetById(id);
        _staffDal.Delete(staff);
    }

    public List<Staff> GetAll()
    {
        return _staffDal.GetList();
    }

    public List<Staff> GetByFullName(string firstName, string lastName)
    {
        return _staffDal.GetList(s => s.FirstName == firstName & s.LastName == lastName).ToList();
    }

    public Staff GetById(int id)
    {
        return _staffDal.Get(s => s.Id == id);
    }

    public void Update(Staff staff)
    {
        ValidationResult result = staffValdiator.Validate(staff);
        if (result.IsValid)
        {
            _staffDal.Update(staff);
        }
        else
        {
            var errors = result.Errors.ToList();
            throw new ValidationException(errors);
        }
    }
}
