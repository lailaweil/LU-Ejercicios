namespace PersonRepository.Entities
{
    public class Person
    {
        public int Id { get; set; } //solo puede haber uno
        public string Name { get; set; } 
        public int Age { get; set; } //no sea cero y no sea negativa
        public string Email { get; set; } //email válido
    }
}
