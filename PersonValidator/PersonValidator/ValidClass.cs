using System;
using System.Linq;
using System.Collections.Generic;
using PersonRepository.Entities;
using PersonRepository.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace PersonValidator
{
    public class ValidClass : IValidatorExpert
    {
        public List<Person> People { get; set; }
        public void Add(Person person)
        {
            if(this.People.Exists(per => per.Id == person.Id)){
                return;
            }else if(person.Age <= 0){
                return;
            }else if(IsValidEmail(person.Email)){
                this.People.Add(person);
            }
        }

        public void Delete(int id)
        {
            int index = this.People.FindIndex(per => per.Id == id);
            
            if(index>=0){
                this.People.RemoveAt(index);
            }
        }

        public int GetCountRangeAges(int min, int max)
        {
            int cant = this.People.FindAll(per => (per.Age >= min && per.Age <= max)).Count();
            if(cant>=0){
                return cant; 
            }return 0;
        }

        public List<Person> GetFiltered(string name, int age, string email)
        {
            Func<Person, bool> FiltroName = p => name == null || name.Length == 0 || p.Name.Equals(name);
            Func<Person, bool> FiltroAge = p => p.Age == age || age == 0;
            Func<Person, bool> FiltroEmail = p => email == null || email.Length == 0 || p.Email.Contains(email);
            
            return this.People.FindAll(per => FiltroAge(per) && FiltroName(per) && FiltroEmail(per));
        }

        public Person GetPerson(int Id)
        {
            return this.People.Find(per => per.Id == Id); 
        }

        public void Update(Person person)
        {
            if(this.People.Exists(per => per.Id == person.Id)==false){
                return;
            }else if(person.Age <= 0){
                return;
            }else if(IsValidEmail(person.Email)){
                int index = this.People.FindIndex(per => per.Id == person.Id);

                this.People[index] = person;    
            }
        }
        private bool IsValidEmail(string email){
            var emailValidator = new EmailAddressAttribute();
            return emailValidator.IsValid(email) && email.Split('@')[1].Contains('.');
        }

        public int[] GetNotCapitalizedIds()
        {
            List<Person> NombreCap = this.People.FindAll(per => !per.Name.Split(' ').All(x => char.IsUpper(x[0])));
            return NombreCap.Select(per => per.Id).ToArray();
        }

        public Dictionary<int, string[]> GroupEmailByNameCount()
        {
            Dictionary<int, string[]> EmailPorCantidad = new Dictionary<int, string[]>();
            for(int i=0; i<=5; i++){
                List<Person> PersonasPorNombre = this.People.FindAll(per => per.Name.Split(' ').Count()==i);
                EmailPorCantidad.Add(i, PersonasPorNombre.Select(per => per.Email).ToArray());
            }
            return EmailPorCantidad;
        }

        public bool Run(Person person, Expression<Func<Person, bool>> validation)
        {
            Func<Person, bool> funcion = validation.Compile();
            return funcion(person);
        }
    }
}
