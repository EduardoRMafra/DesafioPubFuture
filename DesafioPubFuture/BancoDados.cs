using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using DesafioPubFuture.Contas;
using DesafioPubFuture.Receitas;
using DesafioPubFuture.Despesas;

namespace DesafioPubFuture
{
    class BancoDados
    {
        public static SQLiteConnection Conexao;
        static FormPrincipal Form1;
        static ReceitasForm Form2;
        static DespesasForm Form3;

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
                    cmd.CommandText = "UPDATE tb_contas SET T_TipoConta = @tipo, T_InstituicaoFinaiceira = @instituição WHERE ID_conta = @id";
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@instituição", instituicao);
                    cmd.Parameters.AddWithValue("@id", id);
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
        public static void NovaReceita(double valor, DateTime recebimento, DateTime recebimentoEsperado, string descricao, int conta, string tipoReceita)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    valor.ToString("F2");
                    cmd.CommandText = "INSERT INTO tb_receitas (N_Valor, D_DataRecebimento, D_DataRecebimentoEsperado, T_Descrição, T_Conta, T_TipoReceita) VALUES (@valor, @recebimento, @recebimentoEsperado, @descrição, @conta, @tipoReceita)";
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@recebimento", recebimento);
                    cmd.Parameters.AddWithValue("@recebimentoEsperado", recebimentoEsperado);
                    cmd.Parameters.AddWithValue("@descrição", descricao);
                    cmd.Parameters.AddWithValue("@conta", conta);
                    cmd.Parameters.AddWithValue("@tipoReceita", tipoReceita);
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaReceitas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao adicionar uma nova receita!");
            }
        }
        public static void EditarReceita(int idReceita, double valor, DateTime recebimento, DateTime recebimentoEsperado, string descricao, int conta, string tipoReceita)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tb_receitas SET N_Valor = @valor, D_DataRecebimento = @recebimento, D_DataRecebimentoEsperado = @recebimentoEsperado, T_Descrição = @descrição, T_Conta = @conta, T_TipoReceita = @tipoReceita WHERE ID_Receita = @id";
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@recebimento", recebimento);
                    cmd.Parameters.AddWithValue("@recebimentoEsperado", recebimentoEsperado);
                    cmd.Parameters.AddWithValue("@descrição", descricao);
                    cmd.Parameters.AddWithValue("@conta", conta);
                    cmd.Parameters.AddWithValue("@tipoReceita", tipoReceita);
                    cmd.Parameters.AddWithValue("@id", idReceita);
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaReceitas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar editar a receita!");
            }
        }
        public static void DeletarReceita(int id)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_receitas WHERE ID_Receita = " + id;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaReceitas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar excluir a receita!");
            }
        }

        public static void NovaDespesa(double valor, DateTime pagamento, DateTime pagamentoEsperado, string tipoDespesa, int conta)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    valor.ToString("F2");
                    cmd.CommandText = "INSERT INTO tb_despesas (N_Valor, D_DataPagamento, D_DataPagamentoEsperado, T_Conta, T_TipoDespesa) VALUES (@valor, @pagamento, @pagamentoEsperado, @conta, @tipoDespesa)";
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@pagamento", pagamento);
                    cmd.Parameters.AddWithValue("@pagamentoEsperado", pagamentoEsperado);
                    cmd.Parameters.AddWithValue("@conta", conta);
                    cmd.Parameters.AddWithValue("@tipoDespesa", tipoDespesa);
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaDespesas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao adicionar uma nova receita!");
            }
        }
        public static void EditarDespesa(int idDespesa, double valor, DateTime pagamento, DateTime pagamentoEsperado, string tipoDespesa, int conta)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tb_despesas SET N_Valor = @valor, D_DataPagamento = @pagamento, D_DataPagamentoEsperado = @pagamentoEsperado, T_TipoDespesa = @tipoDespesa, T_Conta = @conta WHERE ID_Despesa = @id";
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@pagamento", pagamento);
                    cmd.Parameters.AddWithValue("@pagamentoEsperado", pagamentoEsperado);
                    cmd.Parameters.AddWithValue("@conta", conta);
                    cmd.Parameters.AddWithValue("@tipoDespesa", tipoDespesa);
                    cmd.Parameters.AddWithValue("@id", idDespesa);
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaDespesas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar editar a despesa!");
            }
        }
        public static void DeletarDespesa(int id)
        {
            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tb_despesas WHERE ID_Despesa = " + id;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    AtualizarTabelaDespesas();
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar excluir a receita!");
            }
        }
        static void AtualizarTabelaContas()
        {
            valorTotalConta();
            Form1.dtContas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_contas");    //atualizando as informações da tabela contas
        }
        static void AtualizarTabelaReceitas()
        {
            Form2.dtReceitas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_receitas");    //atualizando as informações da tabela receitas
            AtualizarTabelaContas();
        }
        static void AtualizarTabelaDespesas()
        {
            Form3.dtDespesas.DataSource = BancoDados.ComandoTabela("SELECT * FROM tb_despesas");    //atualizando as informações da tabela despesas
            AtualizarTabelaContas();
        }
        static void valorTotalConta()
        {
            DataTable contas = new DataTable();
            try
            {
                contas = ComandoTabela("SELECT * FROM tb_contas");
                for(int c = 0; c < contas.Rows.Count; c++)
                {
                    double valorTotalConta = 0.00;
                    DataTable dtRecebimento = ComandoTabela("SELECT * FROM tb_receitas WHERE T_conta =" + contas.Rows[c][0]);
                    DataTable dtDespesa = BancoDados.ComandoTabela("SELECT * FROM tb_despesas WHERE T_conta =" + contas.Rows[c][0]);
                    
                    for (int r = 0; r < dtRecebimento.Rows.Count; r++)
                    {
                        valorTotalConta += double.Parse(dtRecebimento.Rows[r][1].ToString());
                    }
                    for (int d = 0; d < dtDespesa.Rows.Count; d++)
                    {
                        valorTotalConta -= double.Parse(dtDespesa.Rows[d][1].ToString());
                    }

                    using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = "UPDATE tb_contas SET N_Saldo = '" + valorTotalConta + "' WHERE ID_conta = " + contas.Rows[c][0];
                        cmd.ExecuteNonQuery();
                        ConexaoBanco().Close();
                    }
                }
            }
            catch (Exception)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Ocorreu um erro ao tentar atualizar saldo da conta!");
            }
        }
        //pegar forms para atualizar as tabelas
        public static void GetFormPrincipal(FormPrincipal f)
        {
            Form1 = f;
        }
        public static void GetFormReceitas(ReceitasForm f)
        {
            Form2 = f;
        }
        public static void GetFormDespesas(DespesasForm f)
        {
            Form3 = f;
        }
    }
}
