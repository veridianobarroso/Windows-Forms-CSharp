using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            resultado.Text = campo_id.Text;
            
        }

        private void botao2_Click(object sender, EventArgs e)
        {
             
            int Id = Convert.ToInt32(campo_id.Text);
            string Nome = campo_nome.Text;
            string Profissao = campo_profissao.Text;
            string Endereco = campo_endereco.Text;

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database= csharp; " +
            "user id = root; " +
            "password=admin;");

            MySqlCommand cmd = new MySqlCommand("insert into pessoa values ('" + Id + "','" + Nome + "','" + Endereco + "','" + Profissao + "' ); ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd
      
            atualizar_ds();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
 

 

        private void btn_desativar_Click(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void carregar_Click(object sender, EventArgs e)
        {

            atualizar_ds();
          

        }
        public void atualizar_ds()
        {
            MySqlConnection con = new MySqlConnection(
          "server = localhost; " +
          "database= csharp; " +
          "user id = root; " +
          "password=admin;");


            MySqlCommand cmd = new MySqlCommand(" select * from pessoa ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd
            /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o
            que tinha dentro do banco,
            agora os passos seguintes irão exibir as informações para
            que o usuário possa vê-las
            */
            MySqlDataAdapter da = new MySqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
            DataSet ds = new DataSet();
            da.SelectCommand = cmd; // adapta cmd ao projeto
            da.Fill(ds); // preenche todas as informações dentro do DataSet
            dados.DataSource = ds; //Datagridview recebe ds já preenchido
            dados.DataMember = ds.Tables[0].TableName;
            /*Agora Datagridview exibe o banco de dados*/
        }

        private void dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            campo_id.Text = dados.CurrentRow.Cells[0].Value.ToString();
            /* ao clicar em uma linha do datagridview, o conteudo é transferido para o texbox */
            campo_nome.Text = dados.CurrentRow.Cells[1].Value.ToString();
            campo_profissao.Text = dados.CurrentRow.Cells[2].Value.ToString();
            campo_endereco.Text = dados.CurrentRow.Cells[3].Value.ToString(); //

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(campo_id.Text);
            string Nome = campo_nome.Text;
            string Profissao = campo_profissao.Text;
            string Endereco = campo_endereco.Text;

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database= csharp; " +
            "user id = root; " +
            "password=admin;");

            MySqlCommand cmd = new MySqlCommand("update pessoa set Nome = '"+Nome+"', Profissao = '"+Profissao+"', Endereco = '"+Endereco+"' where Id = '"+Id+"' ", con);
            
            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd

            atualizar_ds();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(campo_id.Text);
           

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database= csharp; " +
            "user id = root; " +
            "password=admin;");

            MySqlCommand cmd = new MySqlCommand("delete from pessoa where Id = '" + Id + "' ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd

            campo_endereco.Clear();
            campo_id.Clear();
            campo_nome.Clear();
            campo_profissao.Clear();


            atualizar_ds();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}