namespace Money_Money_Money
{
    internal class BankRekening : Rekening
    {
        public override double Berekenrente()
        {
            if (Saldo < 100)
            {
                return Saldo * 1;
            }
            else
            {
                return Saldo * 1.05;
            }
        }
    }
}