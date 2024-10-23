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
                    for(int i = 0; i < line.Length; i++)
                    {
                        //string russian = @"^[А-Яа-яЁё]+$";
                        if ((line[i] >='A') && (line[i] <='я') || line[i]=='Ё' || line[i]=='ё')
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
