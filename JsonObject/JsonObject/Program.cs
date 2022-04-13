﻿using System;
using System.IO;
using JsonObject.Models;
using Newtonsoft.Json;

namespace JsonObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ferrux";
            person.Surname = "Aliyev";
            person.Age = 19;
            person.Adress = new Adress();
            person.Adress.Country = "Azerbaijan";
            person.Adress.City = "Baku";
            person.Adress.PostalCode = 1076;
            person.Adress.State = "Suraxani";

            var serializer = JsonConvert.SerializeObject(person);

            using (StreamWriter sr = new StreamWriter(@"D:\c#\jsonobject\jsonobject\jsconfig.json"))
            {
                sr.WriteLine(serializer);
            }



            var deserializer = JsonConvert.DeserializeObject(serializer);

            //using (StreamWriter srd = new StreamWriter(@"D:\c#\jsonobject\jsonobject\jsconfig.json"))
            //{
            //    srd.WriteLine(deserializer);
            //}

            Console.WriteLine(deserializer);



        }
    }
}
