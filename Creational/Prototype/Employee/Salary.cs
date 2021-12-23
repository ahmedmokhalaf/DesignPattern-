namespace DesignPattern.Creational.Prototype.Employee
{
    class Salary
    {
        private float NetSalary;
        private float Tax;
        private float MedicalInsurance;

        public Salary(float netSalary, float tax, float medicalInsurance)
        {
            NetSalary = netSalary;
            Tax = tax;
            MedicalInsurance = medicalInsurance;
        }

        public float SetNetSalary(float salary) => NetSalary = salary;
        public float SetTax(float tax) => Tax = tax;
        public float SetMedicalInsurance(float medicalInsurance) => MedicalInsurance = medicalInsurance;

        public float GetNetSalary() => NetSalary;
        public float GetTax() => Tax;
        public float GetMedicalInsurance() => MedicalInsurance;

    }
}