namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;
    class Fighter: Machine, IFighter, IMachine
    {
        private const int initialHealthPoints = 200;
        public Fighter(string name, double attackPoint, double defensePoints, bool initialStealthMode)
            : base (name, initialHealthPoints, attackPoint, defensePoints)
        {
            this.StealthMode = initialStealthMode;
        }
        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            string stealthModeAsString = this.StealthMode ? On : Off;
            result.Append(string.Format(" *Stealth: {0}", stealthModeAsString));
            return result.ToString();
        }
    }
}
