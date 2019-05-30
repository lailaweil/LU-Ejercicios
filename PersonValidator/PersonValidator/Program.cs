using System;
using System.Collections.Generic;
using System.Linq;
using PersonRepository;
using PersonRepository.Interfaces;
using PersonRepository.Entities;


namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var va = new ValidatorTest();
            var validator = new ValidClass();
            
            va.Validate(validator);
            
        }
    }
}
