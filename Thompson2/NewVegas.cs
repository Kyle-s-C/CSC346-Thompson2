namespace NewVegasNS
{
    public class NewVegas : IView
    {
        // Properties
        public Global.NameType Name;
        public int Strength;
        public int Perception;
        public int Endurance;
        public int Charisma;
        public int Intelligence;
        public int Agility;
        public int Luck;


        // Default/Overloaded/Parameter constructor
        public NewVegas(Global.NameType name = Global.NameType.COURIER, int strength = 5, int perception = 5, int endurance = 5, int charisma =5, int intelligence = 5, int agility = 5, int luck = 5)
        {
            Strength = strength;
            Perception = perception;
            Endurance  = endurance ;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;
            Name = name;
        }

        // Copy constructor
        public NewVegas(NewVegas copy)
        {
            Strength = copy.Strength;
            Perception = copy.Perception;
            Endurance = copy.Endurance;
            Charisma  = copy.Charisma ;
            Intelligence = copy.Intelligence;
            Agility = copy.Agility;
            Luck = copy.Luck;
            Name = copy.Name;
        }
        
        
        public void ViewH() 
         {
                
            Console.WriteLine("{0,-15} {1,-10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10} {7, -10}", "Name", "Str", "Perc", "End", "Char", "Int", "Agil", "Luck");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-15} {1,-10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10} {7, -10}", Name, Strength, Perception, Endurance, Charisma, Intelligence, Agility, Luck);
          }
        public void ViewV()
        {
            Console.WriteLine("{0,-15} {1, -10}", "Name: ", Name);
            Console.WriteLine("{0,-15} {1, -10}", "Strength: ", Strength);
            Console.WriteLine("{0,-15} {1, -10}", "Perception: ", Perception);
            Console.WriteLine("{0,-15} {1, -10}", "Endurance: ", Endurance);
            Console.WriteLine("{0,-15} {1, -10}", "Charisma: ", Charisma);
            Console.WriteLine("{0,-15} {1, -10}", "Intelligence: ", Intelligence);
            Console.WriteLine("{0,-15} {1, -10}", "Agility: ", Agility);
            Console.WriteLine("{0,-15} {1, -10}", "Luck: ", Luck);
                
        }

    }
}
