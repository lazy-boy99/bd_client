using aircraft_client.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Model.Formatter
{
    public static class QueryFormatter
    {
        

        public static class SelectFormatter
        {
            public static string Get(string field, string table) =>
                "select " + field + " from " + table;

            public static string Get(string field, string table,string condition) =>
                "select " + field + " from " + table+" "+Where(condition);

            public static string Get(string field, string table, List<string> conditions)=>
                (conditions==null ||conditions.Count==0) ?
                Get(field, table):
                Get(field, table)+" "+Where(conditions,"and");

            public static string Get(List<string> fields, string table) =>
                "select "+ConvertFields(fields)+" from "+table;
            
            public static string Get(List<string> fields, string table, string condition)=>
                 Get(fields, table)+" "+Where(condition); 

            public static string Get(List<string> fields, string table, List<string> conditions) =>
                Get(fields, table) + " " + Where(conditions, "and");

            public static string Get(List<string> fields, string table, string subQuery,string choosenFields)=>
               Get(fields, table)+" "+Where(choosenFields,subQuery) ;
            
            public static string Get(string field, string table, string subQuery, string choosenFields)=>
                Get(field, table)+" "+Where(choosenFields,subQuery);

            public static string Union(List<string> fields, List<string> tables)
            {
                var selectTables=new List<string>();
                tables.ForEach(item =>
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Select ");
                    sb.Append(ConvertFields(fields));
                    sb.Append(",'");
                    sb.Append(item);
                    sb.Append("'");
                    sb.Append(" as type");
                    sb.Append(" from ");
                    sb.Append(item);
                    selectTables.Add(sb.ToString());
                });
                return string.Join(" Union ", selectTables);
            }


        }
        private static string ConvertFields(List<string> fields) =>
            string.Join(",", fields);
        //неправильно
        
        public static string BindAnd(List<string> conditions) =>
            string.Join(" and ", conditions);
        
        public static string BindOr(List<string> conditions) =>
           string.Join(" and ", conditions);

        public static string Where(List<string> conditions, string bindType)
        {
            if (bindType == "or")
                return "Where " + BindOr(conditions);
            else if (bindType == "and")
                return "Where " + BindAnd(conditions);
            else
                throw new NotImplementedException("Не поддерживаемый тип для оператора where");
        }

        public static string In(string data, string subquery)=> 
            data+" in (" + subquery+")";

        public static string Where(string condition)=>
            "Where " + condition;

        public static string Where(string data, string subquery) =>
            "Where " + In(data,subquery);
        //bind_fields в виде field1=field2
        //data: select ... from ...
        public static string Join(string data1,string data2,List<string> bind_fields,string qualifier1, string qualifier2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(data1);
            sb.Append(") "+qualifier1+" join (");
            sb.Append(data2);
            sb.Append(") "+qualifier2+" on ");
            bind_fields.ForEach(item => {
                sb.Append(qualifier1);
                sb.Append(".");
                foreach(var c in item)
                {
                    sb.Append(c);
                    if (c == '=')
                    {
                        sb.Append(qualifier2);
                        sb.Append(".");
                    }
                }
            });
            return sb.ToString();
        }

        public static string LeftOuterJoin(string data1, string data2, List<string> bind_fields, string qualifier1, string qualifier2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(data1);
            sb.Append(") " + qualifier1 + " left outer join (");
            sb.Append(data2);
            sb.Append(") " + qualifier2 + " on ");
            bind_fields.ForEach(item => {
                sb.Append(qualifier1);
                sb.Append(".");
                foreach (var c in item)
                {
                    sb.Append(c);
                    if (c == '=')
                    {
                        sb.Append(qualifier2);
                        sb.Append(".");
                    }
                }
            });
            return sb.ToString();
        }
    }

}
