using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //ciplak class kalmasin
    public class PersonManager : IApplicantService
    {
        //encapsulation yaptik Persondan myobj1 ayarinda person cikardik ordan cekecez 
        public void ApplyForMask(Person person)//(string firstName,string lastName,int yil yazdin diyelim seneye adam dediki tc de ekleyelim sikinti o yuzden Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //mernis kontrolu yapilacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.dateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
