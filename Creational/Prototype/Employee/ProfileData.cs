namespace DesignPattern.Creational.Prototype.Employee
{
    internal class ProfileData
    {

        private string Name = "Employee Name";
        private int Age { get; set; }
        private Address? AddR;
        private string TelephoneNumber;
        private string MobileNumber;
        private string SlackAccountName;

        public ProfileData(string name, int age, Address? address, string telephoneNumber, string mobileNumber, string slackAccountName)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Age = age;
            AddR = address;
            TelephoneNumber = telephoneNumber ?? throw new ArgumentNullException(nameof(telephoneNumber));
            MobileNumber = mobileNumber ?? throw new ArgumentNullException(nameof(mobileNumber));
            SlackAccountName = slackAccountName ?? throw new ArgumentNullException(nameof(slackAccountName));
        }

        public string SetName(string name) => Name = name;
        public string getName() => Name;
        public int SetAge(int age) => Age = age;
        public int GetAge() => Age;
        public Address? SetAddress(Address address) => AddR = address;
        public Address? GetAddress() => AddR;
        public string SetTelephoneNumber(string tel) => TelephoneNumber = tel;
        public string GetTelephoneNumber() => TelephoneNumber;
        public string SetMobileNumber(string mob) => MobileNumber = mob;
        public string GetMobileNumber() => MobileNumber;
        public string SetSlackAccountName(string slackAccountName) => SlackAccountName = slackAccountName;
        public string GetSlackAccountName() => SlackAccountName;


    }
}