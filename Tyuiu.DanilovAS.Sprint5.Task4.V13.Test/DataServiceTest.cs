using Tyuiu.DanilovAS.Sprint5.Task4.V13.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask4V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}