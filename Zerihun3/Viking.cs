/********************************************************************
*** NAME : Kaleab Zerihun
*** CLASS : CSc 346
*** ASSIGNMENT : Assignment 3
*** DUE DATE : 03-08-24
*** INSTRUCTOR : GAMRADT
*********************************************************************
*** DESCRIPTION : Viking Class
********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VikingNS
{
    public class Viking
    {
        public string Name { get; set; }
        public short Health { get; set; }
        public Global.Weapon Weapon { get; set; }
        public bool Shield { get; set; }
    /********************************************************************
    *** METHOD <Viking>
    *********************************************************************
    *** DESCRIPTION : Copy constructor for VikingNS class
    *** INPUT ARGS : N/A
    *** OUTPUT ARGS : N/A
    *** IN/OUT ARGS : N/A
    *** RETURN : N/A
    ********************************************************************/
        public Viking(Viking viking)
        {
            Name = viking.Name;
            Health = viking.Health;
            Weapon = viking.Weapon;
            Shield = viking.Shield;
        }
    /********************************************************************
    *** METHOD <Viking>
    *********************************************************************
    *** DESCRIPTION : parametrized constructor for VikingNS class
    *** INPUT ARGS : N/A
    *** OUTPUT ARGS : N/A
    *** IN/OUT ARGS : N/A
    *** RETURN : N/A
    ********************************************************************/

        public Viking(
            string name = "Olaf",
            short health = 100,
            Global.Weapon weapon = Global.Weapon.NONE,
            bool shield = false
        )
        {
            Name = name;
            Health = health;
            Weapon = weapon;
            Shield = shield;
        }
    /********************************************************************
    *** METHOD <ToString>
    ***Override method used to build the string that is going to be displayedCreates a string for the properties of the class
    *** INPUT ARGS : N/A
    *** OUTPUT ARGS : N/A
    *** IN/OUT ARGS : N/A
    *** RETURN : String
    ********************************************************************/

        public override string ToString()
        {
            string forReturn = $"Name:\t{Name}\n";
            forReturn += $"Health:\t{Health}\n";
            forReturn += $"Weapon:\t{Weapon}\n";
            forReturn += $"Shield:\t{Shield}\n";
            return forReturn;
        }
    }
}