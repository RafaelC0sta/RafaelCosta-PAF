using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace rafael_costa_paf_asp
{
    public class Geral
    {
        public static int user_id;
        public static string username;
        public static string nomeCompleto;

        public static string connectionString = ConfigurationManager.ConnectionStrings["pafCon"].ConnectionString;
    }
}