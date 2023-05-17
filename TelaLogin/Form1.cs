namespace TelaLogin
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void iblSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            string login;

            login = Console.ReadLine();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

            int senha;

                senha = Convert.ToInt32(Console.ReadLine());


            
        }

        private void iblEntrar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Sucesso!!!");

        }

        private void iblLogin_Click(object sender, EventArgs e)
        {

        }

        private void iblSenha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}