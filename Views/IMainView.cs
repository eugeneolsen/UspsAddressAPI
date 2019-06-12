using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UspsAddressApi
{
    interface IMainView
    {
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
    }
}
