using System;

namespace Money_Money_Money
{
    internal class ProRekening : SpaarRekening
    {
        public override double Berekenrente()
        {
            int extraRente = Convert.ToInt32(Saldo / 1000) * 10;
            if (Saldo < 1000)
            {
                return base.Berekenrente();
            }
            else
            {
                return base.Berekenrente() + extraRente;
            }
        }
    }
}