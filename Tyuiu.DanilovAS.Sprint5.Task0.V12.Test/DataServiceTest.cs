using System.Diagnostics;
using Tyuiu.DanilovAS.Sprint5.Task0.V12.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            string path = @$"{Path.GetTempPath()}\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}