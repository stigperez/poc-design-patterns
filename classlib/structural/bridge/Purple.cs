namespace classlib.structural.bridge
{
    public class Purple : IColor
    {
        public Purple()
        {
            IsPrimary = false;
        }

        public override string ToString()
        {
            return IsPrimary.ToString();
        }
    }
}