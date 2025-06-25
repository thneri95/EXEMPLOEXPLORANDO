namespace ExemploExplorando.Models
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _name = value;
            }
        }

        public string LastName { get; set; }

        public string FullName => $"{Name} {LastName}".ToUpper();

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than zero");
                }
                _age = value;
            }
        }

        public void Present()
        {
            Console.WriteLine($"Name: {FullName} Age: {Age}");
        }
    }
}