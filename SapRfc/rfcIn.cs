using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;
using System.Data;
using BaseDados;

namespace SapRfc
{
    public class rfcIn
    {
        [RfcServerFunction(Name = "ZHBR_CLIENTE_AUTALIZADO_SAP")]
        public void zhbr_cliente_atualizado_sap(RfcServerContext serverContext, IRfcFunction function)
        {
            try
            {
                csBaseDados bd = new csBaseDados();
                DataTable dtbChanges = new DataTable();
                dtbChanges.Columns.Add("OBJECTID");
                dtbChanges.Columns.Add("FNAME");
                dtbChanges.Columns.Add("VALUE_NEW");

                IRfcTable changes = function.GetTable("T_RET");
                
                foreach(IRfcStructure chg in changes)
                {
                    DataRow row = dtbChanges.NewRow();

                    row["OBJECTID"] = chg.GetString("OBJECTID");
                    row["FNAME"] = chg.GetString("FNAME");
                    row["VALUE_NEW"] = chg.GetString("VALUE_NEW");

                    dtbChanges.Rows.Add(row);
                }

                bd.UpdateClienteFromSap(dtbChanges);
            }
            catch(Exception exp)
            {
                string erro = exp.Message;
            }
        }
    }
}
