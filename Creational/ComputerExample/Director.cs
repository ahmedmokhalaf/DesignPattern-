namespace DesignPattern.Creational.ComputerExample
{
    class Director
    {
        private Builder builder;

        /**
         * Director constructor.
         * @param Builder  builder
         */
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void changeBuilder(Builder builder)
        {
            this.builder = builder;
        }

        public Computer.Types.Computer makeComputer()
        {
            return this.builder.GetComputer();
        }

        public string GetDashboard()
        {
            return this.builder.Dashborad();
        }

    }
}
