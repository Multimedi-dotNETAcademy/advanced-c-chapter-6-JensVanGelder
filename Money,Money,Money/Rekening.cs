namespace Money_Money_Money
{
    internal abstract class Rekening
    {
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
        }

        public void VoegGeldToe(double plus)
        {
            _saldo += plus;
        }

        public void HaalGeldAf(double min)
        {
            _saldo -= min;
        }

        public abstract double Berekenrente();

        public override string ToString()
        {
            return $"{this.GetType().Name} - {Saldo}";
        }
    }
}