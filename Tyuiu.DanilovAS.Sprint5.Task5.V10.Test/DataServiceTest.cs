using Tyuiu.DanilovAS.Sprint5.Task5.V10.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            string path = @"�\DataSprint5\InPutDataFileTask5V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            
        }
    }
}