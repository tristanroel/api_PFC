using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUserRegistered.DAL.Utils
{
    public class ConnectionString
    {
        public string Value { get; set; }

        public ConnectionString(string value)
        {
            this.Value = value;
        }
    }
}
