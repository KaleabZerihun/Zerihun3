/********************************************************************
*** NAME : Kaleab Zerihun
*** CLASS : CSc 346
*** ASSIGNMENT : Assignment 3
*** DUE DATE : 03-08-24
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : Used to test the whole project
********************************************************************/
using System;
using static System.Console;


namespace VikingNS
{
    class Program
    {
/********************************************************************
*** METHOD Main
*********************************************************************
*** DESCRIPTION : Test the program
*** INPUT ARGS : N/A
*** OUTPUT ARGS : N/A
*** IN/OUT ARGS : N/A
*** RETURN : Void
********************************************************************/
        static void Main()
        {
            //testing for viking
            Viking v = new();
            Viking v1 = new("ir",100, Global.Weapon.SWORD,false);
            //Displaying for Viking
            WriteLine(v1.ToString());
            WriteLine("----------------------------------------------");
            WriteLine(v.ToString());
            WriteLine("}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}Karl Class}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}");

            //testing for Karl
            Karl karl = new();
            Karl karl12 = new("name", 23, Global.Weapon.AXE, true, Global.Duty.CRAFTSMAN);
            //Displaying for Karl
            WriteLine(karl.ToString());
            WriteLine(karl12.ToString());


        }
    }
}


