using System;
using ApplicationLogic;
using DataAccess;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonDAO dao = new SqlServerPersonDao();
            
            PeopleService service = new PeopleService(dao);
            
            service.DoSomethingWithPerson();
        }
    }
}
