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
        static string _path = Environment.CurrentDirectory + @"\db\dataB.db";    //caminho banco de dados, ele deve estar dentro da pasta \bin\Debug\net5.0-windows
        public static SQLiteConnection ConexaoBanco()
        {
            Conexao = new SQLiteConnection("Data Source="+ _path);
            Conexao.Open();
            return Conexao;
        }

        public static DataTable ObterTabela(string tabName)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (SQLiteCommand cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM " + tabName;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
