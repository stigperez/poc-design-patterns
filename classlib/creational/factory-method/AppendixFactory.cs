using System;

namespace classlib.creational.factorymethod
{
    public class AppendixFactory : PageFactory
    {
        public override Page CreatePage() => new Appendix();
    }
}