using Microsoft.AspNet.SignalR;
using MVCLinq.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVCLinq.Persist
{
    public class PessoaDAO : Access
    {
        public void Cadastar(Pessoa p)
        {
            try
            {
                Open();
                Cmd = new OleDbCommand("INSERT INTO tarefa (Nome, Cpf) values(@v1, @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Cpf);

                Cmd.ExecuteNonQuery();



            }
            catch (Exception er)
            {
                throw new Exception("Erro ao cadastar: " + er.Message);
            }
            finally
            {
                Close();
            }

        }

        private void Open()
        {
            throw new NotImplementedException();
        }

        public Pessoa ConsultarPorCpf(long Cpf)
        {
            try
            {
                Open();
                Cmd = new OleDbCommand("SELECT * FROM Pessoa WHERE Cpf=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Cpf);
                OleDbDataReader reader = Cmd.ExecuteReader();

                Pessoa p = null;
                if (reader.Read())
                {
                    p = new Pessoa();
                    p.Cpf = Convert.ToInt32(reader["Cpf"]);
                    p.Nome = Convert.ToString(reader["Nome"]);
                    p.Logradouro = Convert.ToString(reader["Logradouro"]);
                    p.Numero = Convert.ToInt32(reader["Numero"]).ToString();
                    p.Cep = Convert.ToInt32(reader["Cep"]).ToString();
                    p.Bairro = Convert.ToString(reader["Bairro"]);
                    p.Cidade = Convert.ToString(reader["Cidade"]);
                    p.Estado = Convert.ToString(reader["Estado"]);
                    p.DDD = Convert.ToInt32(reader["Nome"]).ToString();
                    p.NumeroTelefone = Convert.ToInt32(reader["Nome"]).ToString();
                    p.TipoTelefone = Convert.ToString(reader["Nome"]);
                }
                return p;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao buscar cadastro: " + er.Message);
            }
            finally
            {
                Close();
            }
        }


        public void Excluir(int Cpf)
        {
            try
            {
                Open();
                Cmd = new OleDbCommand("DELETE FROM Pessoa WHERE Cpf = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Cpf);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception er)
            {
                throw new Exception("Erro ao excluir cadastro: " + er.Message);
            }
            finally
            {
                Close();
            }
        }


        public List<Pessoa> Listar()
        {
            try
            {
                List<Pessoa> lista = new List<Pessoa>();

                DataSet ds = new DataSet();
                Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Pessoa order by Cpf", Con);
                da.Fill(ds);
                Con.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {
                    Pessoa p = new Pessoa();
                    p.Cpf = int.Parse(rows["Cpf"].ToString());
                    p.Nome = rows["Nome"].ToString();
                    p.Logradouro = rows["Logradouro"].ToString();
                    p.Numero = rows["Numero"].ToString();
                    p.Cep = rows["Cep"].ToString();
                    p.Bairro = rows["Bairro"].ToString();
                    p.Cidade = rows["Cidade"].ToString();
                    p.Estado = rows["Estado"].ToString();
                    p.DDD = rows["DDD"].ToString();
                    p.NumeroTelefone = rows["NumeroTelefone"].ToString();
                    p.TipoTelefone = rows["TipoTelefone"].ToString();
                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception er)
            {
                throw new Exception("Erro ao listar pessoas :" + er.Message);
            }
            finally
            {
                Close();
            }


        }


        public void Editar(Pessoa p)
        {
            try
            {
                Open();
                Cmd = new OleDbCommand(
                    "UPDATE Tarefa SET Nome=@v2, Logradouro=@v3, Numero=@v4, Cep=@v5, Bairro=@v6, Cidade=@v7, Estado=@v8, DDD=@v9, NumeroTelefone=@v10, TipoTelefone=@v11 WHERE Cep=@v1"
                    , Con);
                Cmd.Parameters.AddWithValue("@v1", p.Cpf);
                Cmd.Parameters.AddWithValue("@v2", p.Nome);
                Cmd.Parameters.AddWithValue("@v3", p.Logradouro);
                Cmd.Parameters.AddWithValue("@v3", p.Numero);
                Cmd.Parameters.AddWithValue("@v5", p.Cep);
                Cmd.Parameters.AddWithValue("@v1", p.Bairro);
                Cmd.Parameters.AddWithValue("@v2", p.Cidade);
                Cmd.Parameters.AddWithValue("@v3", p.Estado);
                Cmd.Parameters.AddWithValue("@v3", p.DDD);
                Cmd.Parameters.AddWithValue("@v5", p.NumeroTelefone);
                Cmd.Parameters.AddWithValue("@v5", p.TipoTelefone);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception er)
            {
                throw new Exception("Erro ao atualizar cadastro: " + er.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}