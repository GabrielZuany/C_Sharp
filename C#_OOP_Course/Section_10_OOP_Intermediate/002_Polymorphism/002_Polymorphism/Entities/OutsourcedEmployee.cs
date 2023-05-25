namespace _002_Polymorphism.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }
        private double additionalChargeTax = 1.1;

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + additionalCharge + (additionalCharge * additionalChargeTax);
        }
    }
}
