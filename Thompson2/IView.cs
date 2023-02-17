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
***               IView will have two methods in an interface     ***
***               which makes it so any class has to provide an   ***
***               implementation for the two methods              ***
********************************************************************/


namespace NewVegasNS
{
    public interface IView 
        {

            /********************************************************************
            *** METHOD: public void ViewH()                                   ***
            *********************************************************************
            *** DESCRIPTION : Being that this method is in an interface it is ***
            ***               considered a interface method and ahs no body.  ***
            ***               The interface makes it so any class has to      ***
            ***               provide an implementation for the method        ***
            *** INPUT ARGS : n/a                                              ***
            *** OUTPUT ARGS : n/a                                             ***
            *** IN/OUT ARGS : n/a                                             ***
            *** RETURN : n/a                                                  ***
            ********************************************************************/
            public void ViewH();

            /********************************************************************
            *** METHOD: public void ViewV()                                   ***
            *********************************************************************
            *** DESCRIPTION : Being that this method is in an interface it is ***
            ***               considered a interface method and ahs no body.  ***
            ***               The interface makes it so any class has to      ***
            ***               provide an implementation for the method        ***
            *** INPUT ARGS : n/a                                              ***
            *** OUTPUT ARGS : n/a                                             ***
            *** IN/OUT ARGS : n/a                                             ***
            *** RETURN : n/a                                                  ***
            ********************************************************************/
            public void ViewV();
        }
        
        
}
