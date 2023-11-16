
namespace Большие_гонки
{
    enum Person_status
    {
        Player,
        Boss
    }
    internal class Person
    {
        public string Name { get; set; }
        public Person_status Status { get; set; }
        public Person(string name, Person_status status) 
        { 
            Name = name;    
            Status = status;
        }
    }
}
