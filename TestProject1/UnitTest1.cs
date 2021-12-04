using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void True_Open_Closed_And_Unlocked_Door()
        {
            DoorClass.Door door = new DoorClass.Door();
            door.ClosedAndUnlocked("123");
            door.Open();
            Assert.AreEqual(true, door.IsOpen());
        }
    }
}
