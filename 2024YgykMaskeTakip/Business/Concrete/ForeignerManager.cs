using Business.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        // SonarQube
        public void ApplyForMask(Person person)
        {
            throw new System.NotImplementedException();
        }
        public List<Person> GetList()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new System.NotImplementedException();
        }

    }
}
