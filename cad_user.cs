using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrescimentoLimpo
{
    public partial class cad_user : Form
    {
        public cad_user()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void confirm_cadastro_Click(object sender, EventArgs e)
        {
            string Nome = register_nome.Text;
            string Login_user = Register_login.Text;
            string senha_user = Register_senha1.Text;
            if (Nome == "" || Login_user == "" || senha_user == "")
            {
                MessageBox.Show("Campos Vazios!", "ERRO!");
                return;
            }

                SqlConnection crescimento = new SqlConnection();
            crescimento.ConnectionString = Properties.Settings.Default.TBcrescimento_limpoConnectionString;
            try {
                crescimento.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "Insert into TBusuario (Nome,login_user,senha_user)values(@Nome,@login,@senha);";
                comando.Parameters.Clear();

                comando.Parameters.Add("@Nome", SqlDbType.VarChar, 150).Value = register_nome.Text;
                comando.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = Register_login.Text;
                comando.Parameters.Add("@senha", SqlDbType.VarChar, 50).Value = Register_senha1.Text;
                comando.CommandType = CommandType.Text;
                comando.Connection = crescimento;
                comando.ExecuteNonQuery();

                MessageBox.Show("Conta Criada.");
                

            }
            catch { 
                MessageBox.Show("Parece que algo deu errado."); 
            
            
            
            
            }
        }
    }
}
