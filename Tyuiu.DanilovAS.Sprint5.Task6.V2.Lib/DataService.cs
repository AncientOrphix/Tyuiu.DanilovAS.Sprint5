﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DanilovAS.Sprint5.Task6.V2.Lib
{
    public class DataService : ISprint5Task6V2
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                 
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    for(int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        //string russian = @"^[А-Яа-яЁё]+$";
                        if ((c >= 'A') || (c <= 'Я'))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
