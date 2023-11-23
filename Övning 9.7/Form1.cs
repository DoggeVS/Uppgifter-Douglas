namespace Övning_9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int nivå = int.Parse(tbxNivå.Text); // Tar inputen och gör om det från string till int
            tbxUtdata.Text = ""; // Ger textboxen ett tomt värde
            

            for(int i = 1; i <= nivå; i++) // Gör en loop som börjar på ett och loopar tills den nått nivån
            {

                for (int j = 1; j <= 10; j++)
                {
                    tbxUtdata.Text = tbxUtdata.Text + (i * j) + "\t"; // Tar nivån och multiplicerar den med J hela vägen upp till tians tabell och gör en tabb för varje tal
                }
                tbxUtdata.Text = tbxUtdata.Text + "\r\n"; // Gör en ny rad efter den är klar med den inre loopen
            }
        }
        }
}