using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Light_Of_Colors_A_Clara_Solução_Para_Sua_Casa
{
    public class conexao
    {
        public SqlConnection sql = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NPC;Data Source=LAPTOP-Q6BSGU1U\\SQLEXPRESS");
    }
}
