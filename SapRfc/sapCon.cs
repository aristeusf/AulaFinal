using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using System.Configuration;

namespace SapRfc
{
    public class sapCon
    {
        Type[] RfcHandlers = new Type[1] { typeof(rfcIn) };

        RfcServer SapHost = null;

        public sapCon()
        {
            SapHost = RfcServerManager.GetServer(ConfigurationManager.AppSettings["RFC_Server"].ToString(), RfcHandlers);

            SapHost.TransactionIDHandler = new IdHandler();
            
        }

        public void CheckRFC()
        {
            SapHost.Start();                
        }
    }

    public class IdHandler : ITransactionIDHandler
    {

        public IdHandler()
        {

        }

        public bool CheckTransactionID(RfcServerContextInfo _ctx, RfcTID _tid)
        {
            return true;
        }


        public void Commit(RfcServerContextInfo ctx, RfcTID tid)
        {

        }

        public void ConfirmTransactionID(RfcServerContextInfo ctx, RfcTID tid)
        {

        }

        public void Rollback(RfcServerContextInfo ctx, RfcTID tid)
        {

        }

    }
}
