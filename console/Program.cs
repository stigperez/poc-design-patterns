using System;
using classlib;

namespace console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var director = new OutputGeneratorDirector();
            try
            {
                var patternTypeValue = args[0];
                var parameter = args.Length  == 1 ? null : args[1];

                var patternType = (PatternType)Enum.Parse(typeof(PatternType), patternTypeValue, true);
                string output = director.GenerateOutput(patternType, parameter);
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                string usingStatement = director.GenerateUsingStatement();
                Console.WriteLine(usingStatement);
            }
        }
    }
}
