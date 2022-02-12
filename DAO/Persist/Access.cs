using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVCLinq.Persist
{
    public class Access : PersistentConnection
    {
        protected OleDbConnection Con;
        protected OleDbCommand Cmd;
        protected OleDbDataAdapter Da;

        protected void Open()
        {
            try
            {
                Con = new OleDbConnection(ConfigurationManager.ConnectionStrings["conexaoBanco"].ConnectionString);
                Con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar conectar com banco de dados: " + ex.Message);
            }

        }

        protected void Close()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar encerrar conexão com banco de dados: " + ex.Message);
            }
        }
    }
}