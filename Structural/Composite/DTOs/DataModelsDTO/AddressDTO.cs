namespace DesignPattern.Structural.Composite.DTOs.DataModelsDTO
{
    class AddressDTO : IDTOModel
    {

        public string StreetNumber { get; private set; }
        public string HouseNumber { get; private set; }
        public string ZipCode { get; private set; }

        public AddressDTO(string streetNumber, string houseNumber, string zipCode)
        {
            StreetNumber = streetNumber;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
        }

        public string[] Render()
        {
            return new string[] { StreetNumber, HouseNumber, ZipCode };
        }
    }
}
