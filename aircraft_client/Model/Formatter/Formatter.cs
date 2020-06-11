using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Model.Formatter
{
    public static class Formatter
    {
        

        public static List<string> GetStringData(DataTable data)=>
            data.Select().AsEnumerable()
                .Select(item => string.Join(" ", item.ItemArray)).ToList();
            

    }
}
