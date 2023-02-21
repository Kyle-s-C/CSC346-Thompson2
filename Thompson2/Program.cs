/********************************************************************
*** NAME : Kyle Thompson                                          ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #2                                    ***
*** DUE DATE : 2-22-23                                            ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Using VS Code create a user-defnined Abstract   ***
***               Data Type using C# classes named NewVegas,      ***
***               Global, and an interface named IView            ***
********************************************************************/
using NewVegasNS;
namespace NewVegasApp

{
    using static Global;
    class Program
    {

        /********************************************************************
        *** METHOD: static void Main(string[] args)                       ***
        *********************************************************************
        *** DESCRIPTION : This method will be the starting point at which ***
        ***               the code inside is executed when ran. In this   ***
        ***               method individual's are created and then are    ***
        ***               able to be viewed via ViewH(); or ViewV();      ***
        *** INPUT ARGS : n/a                                              ***
        *** OUTPUT ARGS : n/a                                             ***
        *** IN/OUT ARGS : n/a                                             ***
        *** RETURN : void - no value                                      ***
        ********************************************************************/
        static void Main(string[] args)
        {
            // Create a new NewVegas object
            NewVegas List1 = new NewVegas(NameType.SOLDIER, 2, 10, 10, 10, 80, 2, 15);

            NewVegas ListDefault = new NewVegas();

            NewVegas cop = new NewVegas(List1);


            // Display the object's properties using both ViewH and ViewV methods
            Console.WriteLine("List1H:");
            List1.ViewH();
            Console.WriteLine();
            Console.WriteLine("List1V:");
            List1.ViewV();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Default:");
            ListDefault.ViewH();




        }

    }
}
