using Business.Abstract;
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
        private IApplicantService _applicantService;//interface

        public PttManager(IApplicantService applicantService) //Consturtor new yapildiginda calisir
        {
            _applicantService = applicantService;//field adlarinin _ baslama sebebi bu 
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))//applicant aday demek
            {
                Console.WriteLine(person.FirstName + "icin maske verildi");
                Console.ReadLine();

            }
        }
    }
}
