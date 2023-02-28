interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}
class Program
{
    class Club : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Club()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
           
        }
        public Club(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        
    }
    static void Main(string[] args)
    {
        
        Club ashley = new Club(10,"Ashley", "Jones");
        Console.WriteLine(ashley.Fullname());
        
        Club jane = new Club();
        jane.Id = 20;
        jane.FirstName = "Jane";
        jane.LastName = "Smith";
     
        Console.WriteLine(jane.Fullname());
        
    }
}

