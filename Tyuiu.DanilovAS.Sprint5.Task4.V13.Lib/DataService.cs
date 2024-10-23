using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');
            

            double x = Convert.ToDouble(strX);
            double res = Math.Cos(x) + Math.Pow(x,2)/2;
            res = Math.Round(res, 3);

            return res;
        }
    }
}
