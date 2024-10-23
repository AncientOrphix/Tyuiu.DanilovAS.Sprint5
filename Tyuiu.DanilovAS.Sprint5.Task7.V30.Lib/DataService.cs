using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "outPutDataFileTask7V30.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string? line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= '0') && (line[i] < '9'))
                        {
                            strLine += '9';
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile,strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
