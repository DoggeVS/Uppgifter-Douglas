namespace Uppgift_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            long tidSek = long.Parse(tbxTid.Text); // Parse texten till int
            long timmar = tidSek / 3600; // Dela tiden i sekunder med 3600 för att få ut antalet timmar
            long minuter = (tidSek % 3600) / 60; // Ta det som blir över vid delning med 3600 delat med 60 för att få ut hur många minuter som blir över
            long sekunder = (tidSek % 60); // Ta tiden i sekunder och ta det som blir över vid delning av 60 alltså efter vi fått fram minuterna och timmarna då 3600/60 samt 60/60 alltid gårs
            lblSvar.Text = "Timmar: " + timmar + "\n" + "Minuter: " + minuter + "\n" + "Sekunder: " + sekunder; // Printa ut reslutatet
        }
    }
}