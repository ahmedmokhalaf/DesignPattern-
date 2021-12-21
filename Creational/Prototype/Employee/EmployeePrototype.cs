using DesignPattern.Creational.Prototype.Employee.Privilege;
using DesignPattern.Creational.Prototype.Employee.Privilege.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype.Employee
{
    class EmployeePrototype : IPrototype
    {
        private ProfileData profileData { get; set; }
        private Salary EmpSalary { get; set; }
        private Privileges EmpPrivileges { get; set; }

        public EmployeePrototype(ProfileData profileData, Salary empSalary, Privileges empPrivileges)
        {
            this.profileData = profileData;
            EmpSalary = empSalary;
            EmpPrivileges = empPrivileges;
        }

        public string EmployeeInformation()
        {
            StringBuilder privilegestring = new StringBuilder();
            EmpPrivileges.GetEmployeePrivileges().ToList().ForEach((privilege) => privilegestring.AppendLine(privilege.GetType().Name).AppendFormat("\t"));
            return "\n ******************************************* \n" +
                $"Name : {profileData.getName()} \n" +
                $"Age : {profileData.GetAge()} \n" +
                $"Telephone Number : {profileData.GetTelephoneNumber()}\n" +
                $"Mobile Number : {profileData.GetMobileNumber()}\n" +
                $"Slack Account : {profileData.GetSlackAccountName()}\n" +
                $"Address :\n" +
                $"\t Building Number : {profileData.GetAddress().GetBuildingNumber()}\n" +
                $"\t StreetName : {profileData.GetAddress().GetStreetName()} \n" +
                $"\t City : {profileData.GetAddress().GetCity()} \n" +
                $"\t Country : {profileData.GetAddress().GetCountry()} \n" +
                $"\t Latitude : {profileData.GetAddress().GetLatitude()} \n" +
                $"\t Longitude : {profileData.GetAddress().GetLongitude()} \n" +
                $"\t ZipCode : {profileData.GetAddress().GetZipCode()} \n" +
                $"Salary: \n" +
                $"\t Salary :{EmpSalary.GetNetSalary()} \n" +
                $"\t Tax : {EmpSalary.GetTax()} \n" +
                $"\t MedicalInsurance: {EmpSalary.GetMedicalInsurance()} \n" +
                $"Employee Privileges : \n" +
                $"\t{privilegestring} \n" +
                $"\n ******************************************* \n";
        }

        public object Clone()
        {
            EmpPrivileges.clearPrivileges();

            EmpPrivileges.SetEmployeePrivileges( new ServerRoomPrivilege());
            EmpPrivileges.SetEmployeePrivileges( new ServerRoomPrivilege());
            EmpPrivileges.SetEmployeePrivileges( new WebPrivilege());
            EmpPrivileges.SetEmployeePrivileges( new NetworkPrivilege());
            
            EmpSalary.SetNetSalary(1500);
            EmpSalary.SetTax((float)0.1);
            EmpSalary.SetMedicalInsurance(300);

            profileData.SetName("Default Employee " + DateTime.UtcNow.ToString());
            profileData.SetAge(18);
            profileData.SetMobileNumber("0");
            profileData.SetTelephoneNumber("0");
            profileData.SetSlackAccountName("Slack Account");

            return this;
        }
    }
}
