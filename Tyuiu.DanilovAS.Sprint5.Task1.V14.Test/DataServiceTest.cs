using Tyuiu.DanilovAS.Sprint5.Task1.V14.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            string path = $@"C:\Users\User\source\repos\Tyuiu.DanilovAS.Sprint5\Tyuiu.DanilovAS.Sprint5.Task1.V14\bin\Release\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}