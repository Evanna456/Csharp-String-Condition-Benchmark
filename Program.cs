using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Csharp_String_Condition_Benchmark
{
    public class IfvsSwitch
    {
        private readonly string data;
        public IfvsSwitch()
        {
            data = "Pneumonoultramicroscopicsilicovolcanoconiosis";
        }

        [Benchmark]
        public string BIf1Condition()
        {
            if (data == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return data;
            }
            else
            {
                return data;
            }
        }

        [Benchmark]
        public string Bswitch1Condition()
        {
            switch (data)
            {
                case "Pneumonoultramicroscopicsilicovolcanoconiosis":
                    return data;
                default:
                    return data;
            }
        }

        [Benchmark]
        public string BIf2Condition()
        {
            if (data == "Cat")
            {
                return data;
            }
            else if (data == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return data;
            }
            else
            {
                return data;
            }
        }
        [Benchmark]
        public string Bswitch2Condition()
        {
            switch (data)
            {
                case "Cat":
                    return data;
                case "Pneumonoultramicroscopicsilicovolcanoconiosis":
                  return data;
                default:
                    return data;
            }
        }
        [Benchmark]
        public string BIf3Condition()
        {
            if (data == "Cat")
            {
                return data;
            }
            else if (data == "Dog")
            {
                return data;
            }
            else if (data == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return data;
            }
            else
            {
                return data;
            }
        }
        [Benchmark]
        public string Bswitch3Condition()
        {
            switch (data)
            {
                case "Cat":
                    return data;
                case "Dog":
                    return data;
                case "Pneumonoultramicroscopicsilicovolcanoconiosis":
                    return data;
                default:
                    return data;
            }
        }
        [Benchmark]
        public string BIf4Condition()
        {
            if (data == "Cat")
            {
                return data;
            }
            else if (data == "Dog")
            {
                return data;
            }
            else if(data == "Rabbit")
            {
                return data;
            }
            else if (data == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return data;
            }
            else
            {
                return data;
            }
        }
        [Benchmark]
        public string Bswitch4Condition()
        {
            switch (data)
            {
                case "Cat":
                    return data;
                case "Dog":
                    return data;
                case "Rabbit":
                    return data;
                case "Pneumonoultramicroscopicsilicovolcanoconiosis":
                    return data;
                default:
                    return data;
            }
        }
        [Benchmark]
        public string BIf5Condition()
        {
            if (data == "Cat")
            {
                return data;
            }
            else if (data == "Dog")
            {
                return data;
            }
            else if (data == "Rabbit")
            {
                return data;
            }
            else if (data == "Horse")
            {
                return data;
            }
            else if (data == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return data;
            }
            else
            {
                return data;
            }
        }
        [Benchmark]
        public string Bswitch5Condition()
        {
            switch (data)
            {
                case "Cat":
                    return data;
                case "Dog":
                    return data;
                case "Rabbit":
                    return data;
                case "Horse":
                    return data;
                case "Pneumonoultramicroscopicsilicovolcanoconiosis":
                    return data;
                default:
                    return data;
            }
        }
        [Benchmark]
        public string BIf6Condition()
        {
            if (data == "Cat")
            {
                return data;
            }
            else if (data == "Dog")
            {
                return data;
            }
            else if (data == "Rabbit")
            {
                return data;
            }
            else if (data == "Horse")
            {
                return data;
            }
            else if (data == "Fish")
            {
                return data;
            }
            else if (data == "Pneumonoultramicroscopicsilicovolcanoconiosis")
            {
                return data;
            }
            else
            {
                return data;
            }
        }
        [Benchmark]
        public string Bswitch6Condition()
        {
            switch (data)
            {
                case "Cat":
                    return data;
                case "Dog":
                    return data;
                case "Rabbit":
                    return data;
                case "Horse":
                    return data;
                case "Fish":
                    return data;
                case "Pneumonoultramicroscopicsilicovolcanoconiosis":
                    return data;
                default:
                    return data;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<IfvsSwitch>();
            Console.ReadLine();
        }
    }
}