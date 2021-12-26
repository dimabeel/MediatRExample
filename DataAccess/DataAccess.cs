using MediatR;
using New_folder.Models;

namespace New_folder.DataAccess;

public class DataAccess : IDataAccess
{
    public List<PersonModel> people;

    public DataAccess()
    {
        people = new List<PersonModel>();
    }

    public PersonModel GetPerson(int id)
    {
        return people.Where(x => x.Id == id).FirstOrDefault() ?? new PersonModel();
    }

    public List<PersonModel> Get()
    {
        return people;
    }

    public Unit DeletePerson(int id)
    {
        var person = people.Where(x => x.Id == id).FirstOrDefault();
        if (person != null)
        {
            people.Remove(person);
            return Unit.Value;
        }
        else
        {
            throw new InvalidDataException($"Wrong person id: {id}");
        }
    }

    public PersonModel InsertPerson(string firstName, string lastName)
    {
        var person = new PersonModel()
        {
            Id = people.Count + 1,
            FirstName = firstName,
            LastName = lastName
        };

        people.Add(person);

        return person;
    }

    public PersonModel UpdatePerson(PersonModel person)
    {
        var personForUpd = people.Where(x => x.Id == person.Id).FirstOrDefault();
        if (personForUpd != null)
        {
            personForUpd.FirstName = person.FirstName;
            personForUpd.LastName = person.LastName;

            return personForUpd;
        }
        else
        {
            throw new InvalidDataException($"Wrong person id: {person.Id}");
        }
    }
}