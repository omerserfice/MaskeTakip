using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System.Collections.Generic;


namespace Business.Concrete
{

    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new System.NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,
                    person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}
