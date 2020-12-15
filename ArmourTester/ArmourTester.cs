using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;
namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void TestLevel1()
        {
Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
//creating variable lvl for level whose value is a call of the method getLevel() of the armour class.
int lvl = ar.getLevel();
if(lvl != 2)
{ 
// calling the method Fail of assert class.
Assert.Fail();        
}
}
        [TestMethod]    
public void TestSlot1()
{ 
Armour ar =new Armour("Jorma", "Kokkeli", 20, 2, 2);
int slot = ar.getSlot();
// if clause
if (slot != 2) 
{
// The code fails
Assert.Fail();

        }
}
}

}
  