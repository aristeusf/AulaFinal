using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using System.Configuration;

namespace SapRfc
{
    public class rfcOut
    {
        public string SalvaCliente(string nome, string cnpj, string logradouro, string bairro, string cidade, string cep, string uf)
        {
            RfcDestination destination = RfcDestinationManager.GetDestination(ConfigurationManager.AppSettings["RFC_Repositorio"].ToString());
            RfcRepository repository = destination.Repository;

            IRfcFunction rfc = repository.CreateFunction("ZHBR_CRIA_CLIENTE");

            rfc.SetValue("I_NOME", nome);
            rfc.SetValue("I_LOGRADOURO", logradouro);
            rfc.SetValue("I_CIDADE", cidade);
            rfc.SetValue("I_CEP", cep);
            rfc.SetValue("I_BAIRRO", bairro);
            rfc.SetValue("I_UF", uf);
            rfc.SetValue("I_CNPJ", cnpj);

            rfc.Invoke(destination);

            IRfcTable t_ret = rfc.GetTable("T_RET");

            return rfc.GetValue("E_CODCLI").ToString();
        }


        public bool EditaCliente(string id, string nome, string cnpj, string logradouro, string bairro, string cidade, string cep, string uf)
        {
            RfcDestination destination = RfcDestinationManager.GetDestination(ConfigurationManager.AppSettings["RFC_Repositorio"].ToString());
            RfcRepository repository = destination.Repository;

            IRfcFunction rfc = repository.CreateFunction("ZHBR_ATUALIZA_CLIENTE");

            rfc.SetValue("I_ID", id);
            rfc.SetValue("I_NOME", nome);
            rfc.SetValue("I_LOGRADOURO", logradouro);
            rfc.SetValue("I_CIDADE", cidade);
            rfc.SetValue("I_CEP", cep);
            rfc.SetValue("I_BAIRRO", bairro);
            rfc.SetValue("I_UF", uf);
            rfc.SetValue("I_CNPJ", cnpj);

            rfc.Invoke(destination);

            IRfcTable t_ret = rfc.GetTable("T_RET");

            string ret = rfc.GetValue("E_RETORNO").ToString();

            if (ret != "ERRO")
            {
                return true;
            }

            return false;
        }
    }
}
