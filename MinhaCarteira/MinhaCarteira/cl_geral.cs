using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace MinhaCarteira
{
    public static class cl_geral
    {
        public static string versao = "v 1.0.1";
        public static string titulo = "Minha Carteira Digital";
        public static string pasta_dados;
        public static string base_dados;

        public static void Iniciar()
        {
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CarteiraDigital\";

            if (!Directory.Exists(pasta_dados))
                Directory.CreateDirectory(pasta_dados);

            //verifica se a base de dados existe.
            base_dados = pasta_dados + "dadoscarteira.sdf";
            if (!File.Exists(base_dados))
                CriarBaseDados();                            
        }

        public static void CriarBaseDados()
        {
            //criação da base de dados
            SqlCeEngine motor = new SqlCeEngine("Data source = " + base_dados);
            motor.CreateDatabase();

            //criar estrutura de base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "Data source = " + base_dados;
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = 
                "CREATE TABLE contas(" +
                "id_conta           int not null primary key, "+
                "descricao           nvarchar(50), " +
                "fornecedor          nvarchar(50), " +
                "datavenc            nvarchar(2), " +
                "atualizacao         datetime)";
            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            //Desconecta o banco
            comando.Dispose();
            ligacao.Dispose();
        }        
    }    
}
