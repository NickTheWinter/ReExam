using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReExam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Тест проверяющий, что критическим путем является путь 1-4-6-7
        public void PrintCritPath1_4_6_7()
        {
            CriticalPath criticalPath = new CriticalPath();
            string[,] dataArray = new string[2, 3];
            int[] expected = { 1, 4, 6, 7 };
            int[] actual = criticalPath.GetCritPath(dataArray);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
