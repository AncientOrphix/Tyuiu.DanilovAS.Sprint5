using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Runtime.CompilerServices;
using Tyuiu.DanilovAS.Sprint5.Task7.V30.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V30.txt"; 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}