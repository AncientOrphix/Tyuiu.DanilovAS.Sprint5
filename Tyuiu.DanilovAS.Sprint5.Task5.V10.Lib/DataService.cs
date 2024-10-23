﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    if (Convert.ToDouble(numbers) %2.0 == 0)
                    {
                        res = res + Convert.ToDouble(numbers);
                    }
                }
            }
            return res;
        }
    }
}
