﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DataStructures
{
    public class StudentProject
    {
        public static void ReadFile()
        {
            string file = @"C:\Users\chara\Documents\citynames.txt";
            string[] lines = File.ReadAllLines(file);
            Console.WriteLine("before sorting the cities");
            foreach (string ln in lines)
                Console.Write(ln + " ");
            Console.WriteLine();
            
            sortingofstrings(lines);
        }
        static void sortingofstrings(string[] cities)
        {
            for (int i = 0; i < cities.Length; i++)
            {
                for (int j = i + 1; j < cities.Length; j++)
                {
                    if (String.Compare(cities[i], cities[j]) > 0)
                    {
                        string temp = cities[i];
                        cities[i] = cities[j];
                        cities[j] = temp;

                    }
                }
            }
            Console.WriteLine("after sorting the cities");
            foreach (string ln in cities)
                Console.Write(ln + " ");
            Console.WriteLine();
            BinarySearch(cities);


        }
    static void BinarySearch(string[] cities)
        {
            int found = -1;
            int mi = 0;
            int ma=cities.Length-1;
            string city;
            Console.WriteLine("enter the city to be searched");
            city=Console.ReadLine();

            while (mi <= ma && found== -1)
            {
                int mid = (mi + ma) / 2;
                if (city == cities[mid])
                {
                    found = mid+1;
                    break;
                }
                else if (String.Compare(city,cities[mid])<0)
                {
                    ma = mid - 1;
                }
                else
                {
                    mi = mid + 1;
                }
            }
            if (found != -1)

                Console.WriteLine($"the {city} city is found at position {found}");
            else
                Console.WriteLine("city is not found");
        }
       
    }
    }

