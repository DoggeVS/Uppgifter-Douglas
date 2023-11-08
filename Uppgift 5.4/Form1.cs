namespace Uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnK�r_Click(object sender, EventArgs e)
        {
            long tidSek = long.Parse(tbxTid.Text); // Parse texten till int
            long timmar = tidSek / 3600; // Dela tiden i sekunder med 3600 f�r att f� ut antalet timmar
            long minuter = (tidSek % 3600) / 60; // Ta det som blir �ver vid delning med 3600 delat med 60 f�r att f� ut hur m�nga minuter som blir �ver
            long sekunder = (tidSek % 60); // Ta tiden i sekunder och ta det som blir �ver vid delning av 60 allts� efter vi f�tt fram minuterna och timmarna d� 3600/60 samt 60/60 alltid g�rs
            lblSvar.Text = "Timmar: " + timmar + "\n" + "Minuter: " + minuter + "\n" + "Sekunder: " + sekunder; // Printa ut reslutatet
        }
    }
}