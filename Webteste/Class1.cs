using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpComSQLServer
{
    public class cadastro
    {
        public static bool email(string email)
        {
            string email = email.Replace(".", "");
            email = email.Replace("-", "");

        }