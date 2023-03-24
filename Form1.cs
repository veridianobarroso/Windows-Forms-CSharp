namespace TesteSistema
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            resultado.Text = num1.Text;
            
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(num1.Text);
            double valor2 = Convert.ToDouble(num2.Text);
            resultado.Text = Convert.ToString(valor1 + valor2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}