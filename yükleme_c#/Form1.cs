namespace yükleme_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            label1.Text = "Yükleniyor Lütfen Bekleyiniz %" +
            progressBar1.Value;

            if (progressBar1.Value >= 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Form2 git = new Form2();    
                git.ShowDialog();
                this.Close();

            }
        }
    }
}
