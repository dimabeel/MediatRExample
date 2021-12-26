using MediatR;
using New_folder.Models;

namespace New_folder.DataAccess;

public interface IDataAccess
{
    Unit DeletePerson(int id);
    List<PersonModel> Get();
    PersonModel GetPerson(int id);
    PersonModel InsertPerson(string firstName, string lastName);
    PersonModel UpdatePerson(PersonModel person);
}