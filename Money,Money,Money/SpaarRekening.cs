namespace Money_Money_Money
{
    internal class SpaarRekening : Rekening
    {
        public override double Berekenrente()
        {
            return Saldo * 1.02;
        }
    }
}