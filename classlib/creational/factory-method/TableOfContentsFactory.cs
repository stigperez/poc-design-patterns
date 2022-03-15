using System;

namespace classlib.creational.factorymethod
{
    public class TableOfContentsFactory : PageFactory
    {
        public override Page CreatePage() => new TableOfContents();
    }
}