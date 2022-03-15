using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlib
{
    public class OutputGeneratorDirector
    {
        private readonly Dictionary<PatternType, IOutputGenerator> _generators;

        public OutputGeneratorDirector()
        {
            var patternTypeNames = Enum.GetNames(typeof(PatternType)).ToList();
            _generators = new Dictionary<PatternType, IOutputGenerator>(patternTypeNames.Count);
            var assemblyTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes());
            patternTypeNames.ForEach(patternTypeName =>
            {
                var patternType = (PatternType)Enum.Parse(typeof(PatternType), patternTypeName, true);
                var outputGeneratorType = assemblyTypes.First(candidate =>
                    !candidate.IsInterface
                    && !candidate.IsAbstract
                    && typeof(IOutputGenerator).IsAssignableFrom(candidate)
                    && candidate.Namespace.Substring(candidate.Namespace.LastIndexOf('.')).Equals($".{patternTypeName}", StringComparison.OrdinalIgnoreCase));
                var outputGenerator = (IOutputGenerator)Activator.CreateInstance(outputGeneratorType);
                _generators.Add(patternType, outputGenerator);
            });
        }

        public string GenerateUsingStatement()
        {
            string patternTypes = string.Join(", ", Enum.GetNames(typeof(PatternType)));
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Usage: console.exe [-ptype] [-param]");
            stringBuilder.AppendLine("Options:");
            stringBuilder.AppendLine($"\t-ptype\t\t\tThe specified pattern type ({patternTypes})");
            stringBuilder.AppendLine("\t-param\t\t\tAny parameter for the pattern type");
            return stringBuilder.ToString();
        }

        public string GenerateOutput(PatternType patternType)
        {
            return GenerateOutput(patternType, null);
        }

        public string GenerateOutput(PatternType patternType, string parameter)
        {
            string output = _generators[patternType].GetOutput(parameter);
            return output;
        }
    }
}