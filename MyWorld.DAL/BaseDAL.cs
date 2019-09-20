using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld.DAL
{
    public class BaseDAL
    {
        protected readonly string conn_MyWorld= ConfigurationManager.ConnectionStrings["conn_MyWorld"].ConnectionString;
    }
}
