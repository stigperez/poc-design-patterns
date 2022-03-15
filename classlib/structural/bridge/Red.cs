namespace classlib.structural.bridge
{
    public class Red : IColor
    {
        public Red()
        {
            IsPrimary = true;
        }

        public override string ToString()
        {
            return IsPrimary.ToString();
        }
    }
}