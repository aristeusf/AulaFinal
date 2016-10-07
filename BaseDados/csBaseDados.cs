using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BaseDados
{
    public class csBaseDados
    {
        bdServerDataContext bd = new bdServerDataContext();

        public List<Estado> getEstados()
        {
            return (from uf in bd.Estados
                    orderby uf.UF
                    select uf).ToList<Estado>();

        }

        public Cliente getClienteById(string id)
        {
            return (from cli in bd.Clientes
                    where cli.id.Equals(id)
                    select cli).First();
        }

        public List<Cliente> getClienteByName(string nome)
        {
            return (from cli in bd.Clientes
                    where cli.Nome.Contains(nome)
                    orderby cli.Nome
                    select cli).ToList<Cliente>();
        }

        public void InsertCliente(string id, string nome, string cnpj, string logradouro, string bairro, string cidade, string cep, string uf)
        {
            Cliente cliente = new Cliente();

            cliente.id = id;
            cliente.Nome = nome;
            cliente.CNPJ = cnpj;
            cliente.Logradouro = logradouro;
            cliente.Bairro = bairro;
            cliente.Cidade = cidade;
            cliente.cep = cep;
            cliente.Pais = "BR";
            cliente.UF = uf;

            bd.Clientes.InsertOnSubmit(cliente);
            bd.SubmitChanges();
        }

        public void UpdateCliente(string id, string nome, string cnpj, string logradouro, string bairro, string cidade, string cep, string uf)
        {
            Cliente cliente = (from cli in bd.Clientes
                                 where cli.id.Equals(id)
                                 select cli).First();

            cliente.Nome = nome;
            cliente.CNPJ = cnpj;
            cliente.Logradouro = logradouro;
            cliente.Bairro = bairro;
            cliente.Cidade = cidade;
            cliente.cep = cep;
            cliente.Pais = "BR";
            cliente.UF = uf;

            bd.SubmitChanges();
        }

        public void UpdateClienteFromSap(DataTable changes)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string sql = "";

            conn.Open();

            for (int i = 0; i < changes.Rows.Count; i++)
            {
                object[] row = changes.Rows[i].ItemArray;

                sql = "update Clientes set " + ConfigurationManager.AppSettings[row[1].ToString()].ToString() + " = '" + row[2].ToString() + "' where id = '" + row[0].ToString() + "'";

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                
            }

            conn.Close();

            
        }
    }
}