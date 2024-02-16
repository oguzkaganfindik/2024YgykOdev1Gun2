using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.NationalIdentity = 12345678910;
            person1.FirstName = "Oğuz";
            person1.LastName = "Kağan";
            person1.DateOfBirthYear = 1234;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
