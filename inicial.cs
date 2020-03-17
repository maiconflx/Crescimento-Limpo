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
    public partial class inicial : Form
    {
        
        public inicial()
        {
            InitializeComponent();
        }

        string Vdocumento = "";
        string Vfilhos = "";
        string Vtrabalha = "";
        string VFamilia = "";
        string Vretorno = "";
        string Vpassagem = "";
        string Vpreso = "";
        string VJudiciais = "";
        string Vhistorico = "";
        string Vdrogas = "";
        string Vtentativa = "";
        string Vtratamento = "";
        string Vinternacaoo = "";
        string Vabstinente = "";
        string Vuso = "";
        string Vajuda = "";
        string Vvontade = "";
        string Vapoio = "";

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cad_user register = new cad_user();
            register.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cad_user register = new cad_user();
            register.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection crescimento = new SqlConnection();
            crescimento.ConnectionString = Properties.Settings.Default.TBcrescimento_limpoConnectionString;
            try
            {
                crescimento.Open();
                SqlCommand comando = new SqlCommand();
                MessageBox.Show("Conectou!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ");


                comando.CommandText = "Insert into TBpaciente (Nome,Possui_Documentos,RG,Data_exp_RG,Info_contato,Idade,Sexo,DataNascimento,Cidade,Estado,Nascionalidade,Nome_Mae,Nome_Pai,Estado_Civil,Filhos,Quantos_Filhos,Escolaridade,Profissao,Trabalha,Ultimo_Emprego,Data, Moradia,Tempo_Rua,Endereco,Rompido_vinculo_Familia,Tempo_Rompido,Motivo_Vinculo,Retornar_Contato,Nao_familia,Detalhe_Culpa,Passagem_Criminal,Preso,Tipo_Delito,Vezes_Preso,Tempo_Preso,Problemas_Atuais_Judiciais,Motivo_Problemas_Judiciais,Historico_Escolar,Ultimo_Lugar,Estudou,Problemas_Drogas_Alcool,Quais_drogas,Tentativa_Parar_Drogas,Buscou_Tratamento,Passou_internacao,Vezes_Internado,Tempo_Abstinente,Atualmente_Abstinente,Dias_Atuais_Abstinente,Esta_Usando,Qual_Substancia,Quer_Ajuda,Deseja_Parar_Drogas,Precisa_Ajuda)values(@Nome,@Panel_Documentos,@RG,@Data_exp_RG,@Info_Contato,@Idade,@Sexo,@data_nascimento,@Cidade,@Estado,@Nascionalidade,@Nome_Mae,@Nome_Pai,@Estado_Civil,@Panel_Filhos,@Quantidade_Filhos,@Escolaridade,@Profissao,@panel_trabalha,@Ultimo_Emprego,@Data, @Moradia,@Tempo_Rua,@Endereco,@panel_familia,@Tempo_Rompido,@Motivo_Vinculo,@panel_contato_familia,@Nao_familia,@Detalhe_Culpa,@panel_passagem,@panel_preso,@Delito,@vezes_preso,@Tempo_preso,@panel_judiciais,@motivo_judiciais,@panel_historico,@Ultimo_estudo,@panel_problemas_drogas,@Tipo_drogas,@panel_parar_drogas,@panel_procurou_tratamento,@panel_passou_tratamento,@Internacao_vezes,@Tempo_abstinente,@panel_abstinente,@abistitente_atual,@Panel_Usa_Atualmente,@Qual_droga,@panel_precisa_ajuda_abstinente,@panel_internacao,@panel_familia_internacao);";

                comando.CommandType = CommandType.Text;
                comando.Connection = crescimento;
                comando.Parameters.Clear();


                if (Documento_Sim.Checked == true)
                {
                    Vdocumento = "SIM";
                }
                else
                { Vdocumento = "NÃO"; }

                if (Filhos_Sim.Checked == true)
                {
                    Vfilhos = "SIM";
                }
                else
                { Vfilhos = "NÃO"; }

                if (Trabalha_Sim.Checked == true)
                {
                    Vtrabalha = "SIM";
                }
                else
                { Vtrabalha = "NÃO"; }

                if (Familia_Sim.Checked == true)
                {
                    VFamilia = "SIM";
                }
                else
                { VFamilia = "NÃO"; }


                if (Retorno_Sim.Checked == true)
                {
                    Vretorno = "SIM";
                }
                else
                { Vretorno = "NÃO"; }

                if (Passagem_Sim.Checked == true)
                {
                    Vpassagem = "SIM";
                }
                else
                { Vpassagem = "NÃO"; }

                if (Preso_Sim.Checked == true)
                {
                    Vpreso = "SIM";
                }
                else
                { Vpreso = "NÃO"; }

                if (Judiciais_Sim.Checked == true)
                {
                    VJudiciais = "SIM";
                }
                else
                { VJudiciais = "NÃO"; }

                if (Historico_Sim.Checked == true)
                {
                    Vhistorico = "SIM";
                }
                else
                { Vhistorico = "NÃO"; }

                if (Drogas_Sim.Checked == true)
                {
                    Vdrogas = "SIM";
                }
                else
                { Vdrogas = "NÃO"; }

                if (Tentativa_Sim.Checked == true)
                {
                    Vtentativa = "SIM";
                }
                else
                { Vtentativa = "NÃO"; }

                if (Tratamento_Sim.Checked == true)
                {
                    Vtratamento = "SIM";
                }
                else
                { Vtratamento = "NÃO"; }

                if (Internacao_Sim.Checked == true)
                {
                    Vinternacaoo = "SIM";
                }
                else
                { Vinternacaoo = "NÃO"; }

                if (Abstinente_Sim.Checked == true)
                {
                    Vabstinente = "SIM";
                }
                else
                { Vabstinente = "NÃO"; }

                if (Uso_Sim.Checked == true)
                {
                    Vuso = "SIM";
                }
                else
                { Vuso = "NÃO"; }

                if (Ajuda_Sim.Checked == true)
                {
                    Vajuda = "SIM";
                }
                else
                { Vajuda = "NÃO"; }

                if (Vontade_Sim.Checked == true)
                {
                    Vvontade = "SIM";
                }
                else
                { Vvontade = "NÃO"; }

                if (Apoio_Sim.Checked == true)
                {
                    Vapoio = "SIM";
                }
                else
                { Vapoio = "NÃO"; }

                comando.Parameters.Add("@Nome", SqlDbType.VarChar, 150).Value = Nome_paciente.Text;


                comando.Parameters.Add("@Possui_Documentos", SqlDbType.Char, 3).Value = Vdocumento;

                comando.Parameters.Add("@RG", SqlDbType.Decimal, 9).Value = RG.Text;
                comando.Parameters.Add("@Data_exp_RG", SqlDbType.Date).Value = Data_exp_RG.Text;
                comando.Parameters.Add("@InfoContato", SqlDbType.VarChar, 200).Value = Info_Contato.Text;
                comando.Parameters.Add("@Idade", SqlDbType.Decimal, 2).Value = Idade.Text;
                comando.Parameters.Add("@Sexo", SqlDbType.Char, 9).Value = Sexo.Text;
                comando.Parameters.Add("@Nascimento", SqlDbType.Date).Value = data_nascimento.Text;
                comando.Parameters.Add("@Cidade", SqlDbType.VarChar, 150).Value = Cidade.Text;
                comando.Parameters.Add("@Estado", SqlDbType.VarChar, 150).Value = Estado.Text;
                comando.Parameters.Add("@Nascionalidade", SqlDbType.VarChar, 20).Value = Nascionalidade.Text;
                comando.Parameters.Add("@Nome_Mae", SqlDbType.VarChar, 150).Value = Nome_Mae.Text;
                comando.Parameters.Add("@Nome_Pai", SqlDbType.VarChar, 150).Value = Nome_Pai.Text;
                comando.Parameters.Add("@Estado_Civil", SqlDbType.VarChar, 20).Value = Estado_Civil.Text;
                comando.Parameters.Add("@Panel_Filhos", SqlDbType.Decimal, 2).Value = Vfilhos;
                comando.Parameters.Add("@Quantidade_FIlhos", SqlDbType.Decimal, 2).Value = Quantidade_Filhos.Text;
                comando.Parameters.Add("@Escolaridade", SqlDbType.VarChar, 50).Value = Escolaridade.Text;
                comando.Parameters.Add("@Profissao", SqlDbType.VarChar, 50).Value = Profissao.Text;
           
                comando.Parameters.Add("@panel_trabalha", SqlDbType.Char, 3).Value = Vtrabalha;

                comando.Parameters.Add("@Ultimo_Emprego", SqlDbType.VarChar, 50).Value = Ultimo_Emprego.Text;              
                comando.Parameters.Add("@Moradia", SqlDbType.VarChar, 30).Value = Moradia.Text;
                comando.Parameters.Add("@Tempo_Rua", SqlDbType.VarChar, 30).Value = Tempo_Rua.Text;
                comando.Parameters.Add("@Endereco", SqlDbType.VarChar, 50).Value = Endereco.Text;
                
                comando.Parameters.Add("@Rompido_vinculo_Familia", SqlDbType.Char, 3).Value = VFamilia;

                comando.Parameters.Add("@Tempo_Rompido", SqlDbType.VarChar, 100).Value = Tempo_Rompido.Text;
                comando.Parameters.Add("@Motivo_Vinculo", SqlDbType.VarChar, 100).Value = Motivo_Vinculo.Text;
                
                comando.Parameters.Add("@panel_contato_familia", SqlDbType.Char, 3).Value = Vretorno;

                comando.Parameters.Add("@Nao_familia", SqlDbType.VarChar, 150).Value = Nao_familia.Text;
                comando.Parameters.Add("@Detalhe_Culpa", SqlDbType.VarChar, 350).Value = Detalhe_Culpa.Text;
                
                comando.Parameters.Add("@Tem_Passagem", SqlDbType.Char, 3).Value = Vpassagem;        
                comando.Parameters.Add("@Preso", SqlDbType.Char, 3).Value = Vpreso;

                comando.Parameters.Add("@Tipo_Delito", SqlDbType.VarChar, 100).Value = Delito.Text;
                comando.Parameters.Add("@Vezes_Preso", SqlDbType.Decimal, 2).Value = vezes_preso.Text;
                comando.Parameters.Add("@Tempo_Preso", SqlDbType.VarChar, 100).Value = Tempo_preso.Text;

                comando.Parameters.Add("@Problemas_Atuais_Judiciais", SqlDbType.Char, 3).Value = VJudiciais;

                comando.Parameters.Add("@Motivo_Problemas_Judiciais", SqlDbType.VarChar, 100).Value = motivo_judiciais.Text;

                comando.Parameters.Add("@Historico_Escolar", SqlDbType.Char, 3).Value = Vhistorico;

                comando.Parameters.Add("@Ultimo_Lugar_Estudou", SqlDbType.Char, 50).Value = Ultimo_estudo.Text;

                comando.Parameters.Add("@Problemas_Drogas", SqlDbType.Char, 3).Value = Vdrogas;

                comando.Parameters.Add("@Quais_Drogas", SqlDbType.VarChar, 100).Value = Tipo_drogas.Text;

                comando.Parameters.Add("@Tentativa_Parar_Drogas", SqlDbType.Char, 3).Value = Vtentativa;
                
                comando.Parameters.Add("@Buscou_Tratamento", SqlDbType.Char, 3).Value = Vtratamento;
               
                comando.Parameters.Add("@Possou_internacao", SqlDbType.Char, 3).Value = Vinternacaoo;

                comando.Parameters.Add("@Vezes_Internado", SqlDbType.Decimal, 2).Value = Internacao_vezes.Text;
                comando.Parameters.Add("@Tempo_Abstinente", SqlDbType.VarChar, 50).Value = Tempo_abstinente.Text;
            
                comando.Parameters.Add("@Abstinente", SqlDbType.Char, 3).Value = Vabstinente;

                comando.Parameters.Add("@Dias_Atuais_Abstinente", SqlDbType.VarChar, 100).Value = abistitente_atual.Text;
           
                comando.Parameters.Add("@Usa_Drogas", SqlDbType.Char, 3).Value = Vuso;

                comando.Parameters.Add("@Qual_Substancia", SqlDbType.VarChar, 100).Value = Qual_droga.Text;
            
                comando.Parameters.Add("@Quer_Ajuda", SqlDbType.Char, 3).Value = Vajuda;
        
                comando.Parameters.Add("@Deseja_Parar_Drogas", SqlDbType.Char, 3).Value = Vvontade;
                comando.Parameters.Add("@Precisa_Ajuda", SqlDbType.Char, 3).Value = Vapoio;
               

                

                comando.ExecuteNonQuery();


                MessageBox.Show("Registro salvo.");
            }
            catch
            {
                MessageBox.Show("Parece que algo deu errado.");




            }






        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel_Documentos_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RG_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_criação_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tBcrescimento_limpoDataSet.TBpaciente'. Você pode movê-la ou removê-la conforme necessário.


        }

        private void Panel_Documentos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Panel_Filhos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Documentos_SIM_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void Pesquisa_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBpacienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Documentos_Enter(object sender, EventArgs e)
        {
        
        }
    }
}
