using Tyuiu.DanilovAS.Sprint5.Task2.V9.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}