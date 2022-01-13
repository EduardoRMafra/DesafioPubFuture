using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DesafioPubFuture
{
    class BancoDados
    {
        public static SQLiteConnection Conexao;
        static FormPrincipal Form1;
        static Receitas Form2;
        static Despesas Form3;

        static string _path = Environment.CurrentDirectory + @"\db\dataB.db";    //caminho banco de dados, ele deve estar dentro da pasta \bin\Debug\net5.0-windows
        public static SQLiteConnection ConexaoBanco()
        {
            Conexao = new SQLiteConnection("Data Source="+ _path);
            Conexao.Open();
            return Conexao;
        }
        public static DataTable ComandoTabela(string sql)
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch(Exception e)
            {
                ConexaoBanco().Close();
                throw e;
            }
        }
        public static void NovaConta(string tipo, string instituicao)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tb_contas (N_Saldo, T_TipoConta, T_InstituicaoFinaiceira) VALUES (@saldo, @tipo, @instituicao)";
                    cmd.Parameters.AddWithValue("@saldo", 0);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@instituicao", instituicao);
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaContas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao adicionar uma nova conta!");
            }
        }
        public static void EditarConta(int id,string tipo, string instituicao)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tb_contas SET T_TipoConta = '" + tipo + "' WHERE ID_conta = " + id;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE tb_contas SET T_InstituicaoFinaiceira = '" + instituicao + "' WHERE ID_conta = " + id;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaContas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar editar a conta!");
            }
        }
        public static void DeletarConta(int id)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_contas WHERE ID_conta = " + id;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaContas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar excluir a conta!");
            }
        }

        static void AtualizarTabelaContas()
        {
            Form1.dtContas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_contas");    //atualizando as informações da tabela contas
        }
        static void AtualizarTabelaReceitas()
        {
            Form2.dtReceitas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_receitas");    //atualizando as informações da tabela receitas
        }
        static void AtualizarTabelaDespesas()
        {
            Form3.dtDespesas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_despesas");    //atualizando as informações da tabela despesas
        }
        //pegar forms para atualizar as tabelas
        public static void GetFormPrincipal(FormPrincipal f)
        {
            Form1 = f;
        }
        public static void GetFormReceitas(Receitas f)
        {
            Form2 = f;
        }
        public static void GetFormDespesas(Despesas f)
        {
            Form3 = f;
        }
    }
}
