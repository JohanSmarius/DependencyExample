using System;
using DataAccess;

namespace ApplicationLogic
{
    public class PeopleService : IPeopleService
    {
        private readonly IPersonDAO _personDao;

        public PeopleService(IPersonDAO personDao)
        {
            _personDao = personDao ?? throw new ArgumentNullException(nameof(personDao));
        }

        public void DoSomethingWithPerson()
        {
            
        }




    }
}