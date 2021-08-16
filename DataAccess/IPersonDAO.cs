using Domain;

namespace DataAccess
{
    public interface IPersonDAO
    {
        void SavePerson(Person person);
    }
}