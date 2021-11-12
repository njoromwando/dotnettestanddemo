using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Model;

namespace DemoLibrary.DataAccess
{
   public class DemoDataAccess
   {
       private List<PersonsModel> people = new();

       public DemoDataAccess()
       {
           people.Add(new PersonsModel{Id = 1,FirstName = "James" , LastName = "Njoroge"});
           people.Add(new PersonsModel { Id = 1, FirstName = "Maggy", LastName = "MWando" });
           people.Add(new PersonsModel { Id = 1, FirstName = "Timmy", LastName = "Tunner" });
           people.Add(new PersonsModel { Id = 1, FirstName = "Rodger", LastName = "That" });
        }

       public List<PersonsModel> GetPeople()
       {
           return people;
       }

       public PersonsModel InsertPerson(string firstName,string lastName)
       {
           var p = new PersonsModel
           {
               FirstName = firstName, 
               LastName = lastName,
               Id = people.Max(x => x.Id) + 1,
           };


           people.Add(p);

           return p;
       }

   }
}
