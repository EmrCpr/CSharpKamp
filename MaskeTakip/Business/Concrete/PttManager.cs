using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public  class PttManager
    {
        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "icin maske verildi");
                Console.ReadLine();

            }
        }
    }
}
