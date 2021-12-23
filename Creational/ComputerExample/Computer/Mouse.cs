namespace DesignPattern.Creational.ComputerExample.Computer
{
    class Mouse
    {
        private bool WithExtraUtilities;

        public Mouse(bool withExtraUtilities)
        {
            WithExtraUtilities = withExtraUtilities;
        }

        public bool IswithExtraUtilities() => WithExtraUtilities;
    }
}
