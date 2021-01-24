using System;
using System.Windows.Forms;

namespace Money_Money_Money
{
    public partial class FormMoney : Form
    {
        private Rekening bank = new BankRekening();
        private Rekening spaar = new SpaarRekening();
        private Rekening pro = new ProRekening();

        public FormMoney()
        {
            InitializeComponent();
        }

        private void FormMoney_Load(object sender, EventArgs e)
        {
            listRekening.Items.Add(bank);
            bank.VoegGeldToe(2500);
            listRekening.Items.Add(bank);
            listRekening.Items.Add($"Met rente = {bank.Berekenrente()}");
            bank.HaalGeldAf(2450);
            listRekening.Items.Add(bank);
            listRekening.Items.Add($"Met rente = {bank.Berekenrente()}");
            listRekening.Items.Add("");
            listRekening.Items.Add(spaar);
            spaar.VoegGeldToe(2500);
            listRekening.Items.Add($"Met rente = {spaar.Berekenrente()}");
            listRekening.Items.Add("");
            pro.VoegGeldToe(2500);
            listRekening.Items.Add(pro);
            listRekening.Items.Add($"Met rente = {pro.Berekenrente()}");
            pro.HaalGeldAf(1600);
            listRekening.Items.Add(pro);
            listRekening.Items.Add($"Met rente = {pro.Berekenrente()}");
        }
    }
}