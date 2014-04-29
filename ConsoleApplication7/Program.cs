using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Threading;

namespace ConsoleApplication7
{
    class Program
    {
        static bool Validator<T>(string line)
        {
            var valueTypeConverter = TypeDescriptor.GetConverter(typeof(T));
            if (!valueTypeConverter.CanConvertFrom(typeof (string))) return false;

            try
            {
                valueTypeConverter.ConvertFrom(line);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false; 
            }
        }
        static void Main(string[] args)
        {
            bool repeat = false;
            while (!repeat)
            {
                repeat = Validator<int>(Console.ReadLine());
            }
            Console.ReadKey(); 
        }
    }
}
