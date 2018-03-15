using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace TesteEstagio
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }




        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ds_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void vcpf_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text;

            if (ValidarCpf.Vcpf(cpf))
            {
                MessageBox.Show("CPF válido");
            }
            else
                MessageBox.Show("CPF inválido");

        }
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void vcnpj_Click(object sender, EventArgs e)
        {
            string cnpj = mskCpf.Text;

            if (ValidarCNPJ.Vcnpj(cnpj))
            {
                MessageBox.Show("CNPJ válido");
            }
            else
                MessageBox.Show("CNPJ inválido");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cadastro_cliente;Data Source=DESKTOP-9BPMVSD");
            SqlCommand comando = new SqlCommand("insert into [tb-cadastro](nome, email, idade, cpf, cnpj, endereco, tipo) values (@nome, @email, @idade, @cpf, @cnpj, @end, @tipo)",sqlcon);


            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = mskEmail.Text;
            comando.Parameters.Add("@idade", SqlDbType.VarChar).Value = mskIdade.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mskCpf.Text;
            comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = mskCnpj.Text;
            comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = txtTipo.Text;
            comando.Parameters.Add("@end", SqlDbType.VarChar).Value = txtEnd.Text;



            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }

            txtNome.Clear();
            mskEmail.Clear();
            mskIdade.Clear();
            mskCpf.Clear();
            mskCnpj.Clear();
            txtEnd.Clear();
            txtTipo.Clear();


        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void rdFis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tdJud_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cadastro_cliente;Data Source=DESKTOP-9BPMVSD");
            SqlCommand comando = new SqlCommand("select * from [tb-cadastro] where nome = @nome", sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtPesquisa.Text;
            try
            {
                sqlcon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception(("Nome não encontrado"));
                }
                dr.Read();

                txtNome.Text = Convert.ToString(dr["nome"]);
                mskEmail.Text = Convert.ToString(dr["email"]);
                mskCpf.Text = Convert.ToString(dr["cpf"]);
                mskCnpj.Text = Convert.ToString(dr["nome"]);
                mskIdade.Text = Convert.ToString(dr["idade"]);
                txtEnd.Text = Convert.ToString(dr["endereco"]);
                txtTipo.Text = Convert.ToString(dr["tipo"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }

            txtPesquisa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cadastro_cliente;Data Source=DESKTOP-9BPMVSD");
            SqlCommand comando = new SqlCommand("update [tb-cadastro] set nome=@nome, email=@email, cpf=@cpf, cnpj=@cnpj, idade=@idade, tipo=@tipo, endereco=@end where cpf=@cpf",sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = mskEmail.Text;
            comando.Parameters.Add("@idade", SqlDbType.VarChar).Value = mskIdade.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = mskCpf.Text;
            comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = mskCnpj.Text;
            comando.Parameters.Add("@tipo", SqlDbType.VarChar).Value = txtTipo.Text;
            comando.Parameters.Add("@end", SqlDbType.VarChar).Value = txtEnd.Text;


            try
            {
                sqlcon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }

            txtNome.Clear();
            mskEmail.Clear();
            mskIdade.Clear();
            mskCpf.Clear();
            mskCnpj.Clear();
            txtEnd.Clear();
            txtTipo.Clear();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                 Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = mskEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                MessageBox.Show("E-mail Válido");
            else
                MessageBox.Show("E-mail Inválido");
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
