using Tyuiu.VorobevAD.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VorobevAD.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Addition(10, 5));
        }

        public void CheckedMultioplicationValid()
        {
            Assert.AreEqual(50, DataService.Addition(5, 10));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

    }
}