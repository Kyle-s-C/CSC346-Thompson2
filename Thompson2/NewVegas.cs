/********************************************************************
*** NAME : Kyle Thompson                                          ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 2-22-23                                            ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Using VS Code create a user-defnined Abstract   ***
***               Data Type using C# classes named NewVegas,      ***
***               Global, and an interface named IView.           ***
***               NewVegas describes the current state of an      ***
***               individual NewVegas class instance.             ***
********************************************************************/
namespace NewVegasNS
{
    using static Global;
    public class NewVegas : IView
    {
        // Properties
        public NameType Name {get; set;}
        public int Strength {get; set;}
        public int Perception {get; set;}
        public int Endurance {get; set;}
        public int Charisma {get; set;}
        public int Intelligence {get; set;}
        public int Agility {get; set;}
        public int Luck {get; set;}


        /*********************************************************************
        *** METHOD: public NewVegas(....)                                      ***
        **********************************************************************
        *** DESCRIPTION : This is the default/overloaded/parameterized     ***
        ***               constructor. If no attributes are set when       ***
        ***               creating a character all will be default of 5,   ***
        ***               otherwise set to what is specified.              ***
        *** INPUT ARGS :NameType name = NameType.COURIER, int strength = 5,***
        ***  int perception = 5, int endurance = 5, int charisma =5,       ***    
        ***  int intelligence = 5, int agility = 5, int luck = 5           ***                                         ***
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : returns a new instance of NewVegas object             ***
        *********************************************************************/
        public NewVegas(NameType name = NameType.COURIER, int strength = 5, int perception = 5, int endurance = 5, int charisma =5, int intelligence = 5, int agility = 5, int luck = 5)
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

        /*********************************************************************
        *** METHOD: public NewVegas                                        ***
        **********************************************************************
        *** DESCRIPTION : This is the copy constructor which copies        ***
        ***               all attributes from one NewVegas object instance ***
        ***               to another NewVegas object instance              ***
        *** INPUT ARGS : NewVegas copy                                     ***                                         ***
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : n/a                                                   ***
        *********************************************************************/
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
        
        /********************************************************************
        *** METHOD: public void ViewH()                                   ***
        *********************************************************************
        *** DESCRIPTION : this will implement the ViewH() method that was ***
        ***               defined in the IView interface. This will       ***
        ***               actually display the attributes of a NewVegas   ***
        ***               character.                                      ***
        *** INPUT ARGS : n/a                                              ***
        *** OUTPUT ARGS : n/a                                             ***
        *** IN/OUT ARGS : n/a                                             ***
        *** RETURN : n/a                                                  ***
        ********************************************************************/
        public void ViewH() 
         {
                
            Console.WriteLine("{0,-15} {1,-10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10} {7, -10}", "Name", "Str", "Perc", "End", "Char", "Int", "Agil", "Luck");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-15} {1,-10} {2, -10} {3, -10} {4, -10} {5, -10} {6, -10} {7, -10}", Name, Strength, Perception, Endurance, Charisma, Intelligence, Agility, Luck);
          }

        /********************************************************************
        *** METHOD: public void ViewV()                                   ***
        *********************************************************************
        *** DESCRIPTION : this will implement the ViewV() method that was ***
        ***               defined in the IView interface. This will       ***
        ***               actually display the attributes of a NewVegas   ***
        ***               character.                                      ***
        *** INPUT ARGS : n/a                                              ***
        *** OUTPUT ARGS : n/a                                             ***
        *** IN/OUT ARGS : n/a                                             ***
        *** RETURN : n/a                                                  ***
        ********************************************************************/
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
