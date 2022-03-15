using System;

namespace classlib.creational.factorymethod
{
    public class BodyFactory : PageFactory
    {
        public override Page CreatePage() => new Body();
    }
}