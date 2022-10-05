using CompulsoryAssignment;

namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly PrimeGenerator pg;
        public Form1()
        {
            InitializeComponent();
            pg = new PrimeGenerator();
        }

        private async void btn_calculatePrimes_Click(object sender, EventArgs e)
        {
            try
            {
                long firstNumber = long.Parse(tb_first.Text);
                long lastNumber = long.Parse(tb_last.Text);

                List<long> primeNumbers = await pg.GetPrimesAsync(firstNumber, lastNumber);

                lb_list.DataSource = primeNumbers;
            } catch (Exception)
            {
                lb_list.DataSource = null;
            }

            
            
        }
    }
}