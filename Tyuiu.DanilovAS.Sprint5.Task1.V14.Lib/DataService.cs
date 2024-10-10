using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.Combine("OutPutFileTask1.txt")}";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double result;
            string strResult;

            for (double x = startValue; x <= stopValue; x++)
            {
                result = (Math.Sin(x)) / (x + 1.7) - Math.Cos(x) * 4 * x - 6;
                strResult = Convert.ToString(result);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strResult + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strResult);
                }
            }
            return path;
        }
    }
}
