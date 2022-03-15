using System;

namespace classlib.creational.factorymethod
{
    public class FactoryMethodOutputGenerator : BaseOutputGenerator
    {
        public override string GetOutput()
        {
            throw new ApplicationException("You must supply a parameter for this pattern");
        }
        public override string GetOutput(string parameter)
        {
            // the most simple use of a factory is with a switch-statement
            PageFactory factory = null;
            switch (parameter)
            {
                case "TableOfContents":
                {
                    factory = new TableOfContentsFactory();
                    break;
                }
                case "Body":
                {
                    factory = new BodyFactory();
                    break;
                }
                case "Appendix":
                {
                    factory = new AppendixFactory();
                    break;
                }
                default:
                {
                    throw new NotImplementedException();
                }
            }
            return factory.CreatePage().Content;
        }
    }
}