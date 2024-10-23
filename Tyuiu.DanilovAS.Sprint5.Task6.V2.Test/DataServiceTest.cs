using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Runtime.CompilerServices;
using Tyuiu.DanilovAS.Sprint5.Task6.V2.Lib;

namespace Tyuiu.DanilovAS.Sprint5.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"Ñ:\DataSprint5\InPutDataFileTask6V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true; 
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"Ñ:\DataSprint5\InPutDataFileTask6V2.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }

    }
}