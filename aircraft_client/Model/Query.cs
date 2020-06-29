using aircraft_client.Model.Formatter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Configuration;
using static aircraft_client.Model.Formatter.QueryFormatter;

namespace aircraft_client.Model
{
    public static class  Query
    {
        

        public static string GetExperimentsByScientist(string nameScientist)
        {
            var name = nameScientist.Split(' ');

            var expIdQuery = QueryFormatter.SelectFormatter.Get("exp_id"
                , "investigators"
                , new List<string> {"first_name='"+name[0]+"'"
                    ,"last_name='"+name[1]+"'"
                    ,"patronymic='"+name[2]+"'" });

            var prodExpQuery = QueryFormatter.SelectFormatter.Get(new List<string>{
                    "time_begin"
                    ,"time_end"
                    ,"prod_id"
                    ,"exp_id" }
                , "products_exps"
                , expIdQuery
                , "exp_id");

            var expNameQuery=QueryFormatter.SelectFormatter
                .Get(new List<string> { "id", "name" }, "experiments",expIdQuery,"id");

            var joinQuery = QueryFormatter.Join(prodExpQuery
                , expNameQuery
                , new List<string> { "exp_id=id" }
                , "t1"
                , "t2");

            joinQuery = QueryFormatter.SelectFormatter.Get("*", joinQuery);

            var unionQuery = QueryFormatter.SelectFormatter
                         .Union(new List<string> { "name", "prod_id" }
                         , new List<string> { "rockets"
                            , "gliders"
                            , "hang_gliders"
                            , "helicopters"
                            , "planes"
                            , "other_prods" });

            joinQuery = QueryFormatter.Join(joinQuery
                , unionQuery
                , new List<string> { "prod_id=prod_id" }
                , "t3"
                , "t4");

            return QueryFormatter.SelectFormatter.Get(new List<string>{
                    "t3.name"
                    ,"t4.name"
                    ,"time_begin"
                    ,"time_end" }
                , joinQuery);
        }

        public static string GetToolsByLaboratory(string name)
        {
            var labIdQuery = QueryFormatter.SelectFormatter.Get("id", "laboratories", "name='" + name+"'");
            return QueryFormatter.SelectFormatter.Get("name", "tools",  labIdQuery,"lab_id");
        }

        public static string GetProductsNames(string id)
        {
            var query=SelectFormatter.Union(new List<string> { "name", "prod_id" }, new List<string> { "rockets"
                            , "gliders"
                            , "hang_gliders"
                            , "helicopters"
                            , "planes"
                            , "other_prods" });
            return SelectFormatter.Get("name", "("+query+")", id, "prod_id" );
        }

        public static string GetProductsNames()=>
            SelectFormatter.Union(new List<string> { "name" }, new List<string> { "rockets"
                            , "gliders"
                            , "hang_gliders"
                            , "helicopters"
                            , "planes"
                            , "other_prods" });
    

        public static string GetCategoryQuery(CategoryProd type) =>
            type switch
            {
                CategoryProd.All =>
                    QueryFormatter.SelectFormatter
                     .Union(new List<string> { "name", "prod_id" }
                         , new List<string> { "rockets"
                            , "gliders"
                            , "hang_gliders"
                            , "helicopters"
                            , "planes"
                            , "other_prods" }),
                CategoryProd.HangGliders =>
                    QueryFormatter.SelectFormatter
                        .Get(new List<string> { "name", "aero_qual", "prod_id", "'дельтаплан' as type" }
                            , "hang_gliders"),
                CategoryProd.Helicopters =>
                    QueryFormatter.SelectFormatter
                        .Get(new List<string> { "name", "speed", "prod_id", "'вертолет' as type" }
                            , "helicopters"),
                CategoryProd.Other =>
                    QueryFormatter.SelectFormatter
                        .Get(new List<string> { "name", "type_prod", "prod_id", "'другая продукция' as type" }
                            , "other_prods"),
                CategoryProd.Planes => QueryFormatter.SelectFormatter
                        .Get(new List<string> { "name", "count_engines", "prod_id", "'самолет' as type" }
                            , "planes"),
                CategoryProd.Rockets => QueryFormatter.SelectFormatter
                        .Get(new List<string> { "name", "power", "prod_id", "'ракета' as type" }
                            , "rockets"),
                CategoryProd.Gliders => QueryFormatter.SelectFormatter
                        .Get(new List<string> { "name", "wingspan", "prod_id", "'ракета' as type" }
                            , "gliders"),
                CategoryProd.ChooseProd=>"one product",
                _ => throw new NotImplementedException("Выбраной категории не существует")
            };

        public static string GetCategoryQuery(CategoryTechnics type) =>
            type switch
            {
                CategoryTechnics.All => SelectFormatter
                            .Get(new List<string>{"first_name"
                                ,"last_name","patronymic" ,"id"}, "technics"),
                CategoryTechnics.Technicians=>GetCategoryTechQuery("'техник' as type"
                    ,"technicians", "category"),
                CategoryTechnics.Technologists => GetCategoryTechQuery("'технолог' as type"
                    , "technologists", "technology_dev"),
                CategoryTechnics.Engineers => GetCategoryTechQuery("'инженер' as type"
                    , "engineers", "specialization"),
                _ => throw new NotImplementedException("Выбраной категории не существует")
            };

        public static string GetCategoryQuery(CategoryWorkers type)=>
            type switch{
                CategoryWorkers.All=> SelectFormatter
                            .Get(new List<string>{"first_name"
                                ,"last_name","patronymic" ,"id"}, "workers"),

                CategoryWorkers.Collectors=> GetCategoryWorkerQuery("'сборщик' as type"
                    ,"collectors","work_exp"),
                CategoryWorkers.Fitters=> GetCategoryWorkerQuery("'слесарь' as type"
                    , "fitters", "category"),
                CategoryWorkers.Others=> GetCategoryWorkerQuery("'иная профессия' as type"
                    , "other_workers", "name_prof"),
                CategoryWorkers.Turners=> GetCategoryWorkerQuery("'токарь' as type"
                    , "turners", "amount_fingers"),
                CategoryWorkers.Welders => GetCategoryWorkerQuery("'слесарь' as type"
                    , "welders", "specialization"),
                _ => throw new NotImplementedException("Выбраной категории не существует")
            };

        private static string GetCategoryTechQuery(string type, string table, string specField)
        {
            var queryProf = SelectFormatter.Get(new List<string> {"tech_id"
                        ,specField
                        ,type }
                        , table);
            var queryWork = SelectFormatter.Get(new List<string> { "first_name"
                            ,"last_name"
                            ,"patronymic"
                            ,"id"}
                , "technics");
            var queryJoin = Join(queryProf, queryWork
                , new List<string> { "tech_id=id" }, "t1", "t2");
            return SelectFormatter.Get("*", "(" + queryJoin + ")");
        }

        private static string GetCategoryWorkerQuery(string type,string table,string specField)
        {
            var queryProf = SelectFormatter.Get(new List<string> {"work_id"
                        ,specField
                        ,type }
                        , table);
            var queryWork = SelectFormatter.Get(new List<string> { "first_name"
                            ,"last_name"
                            ,"patronymic"
                            ,"id"}
                , "workers");
            var queryJoin = Join(queryProf, queryWork
                , new List<string> { "work_id=id" }, "t1", "t2");
            return SelectFormatter.Get("*", "(" + queryJoin + ")");
        }

        public static string GetProdIdByWsName(string WsName,ProdChoosenMode mode,string timeBeg, string timeEnd) {
            var query = QueryFormatter.SelectFormatter.Get("id" , "workshops", "name='" + WsName + "'");
            if (mode == ProdChoosenMode.ProdType)
            {
                return QueryFormatter.SelectFormatter.Get("id", "products", "workshop_id=(" + query + ")");
            }
            else
            {
                var conditionLs = new List<string>();
                AddConditionsByMode(conditionLs, mode, timeBeg, timeEnd);
                conditionLs.Add(QueryFormatter.In("prod_id", query));
               return QueryFormatter.SelectFormatter.Get( "prod_id" , "products_jobs", conditionLs);
            }
        }

        public static string GetWorkIdByWsName(string WsName)
        {
            var query = QueryFormatter.SelectFormatter.Get("id", "workshops", "name='" + WsName + "'");
            query = SelectFormatter.Get("id", "products", query, "workshop_id");
            query = SelectFormatter.Get("team_id", "products_jobs", query, "prod_id");
            return SelectFormatter.Get("id", "workers", query, "team_id");
        }

        public static string GetTechIdByWsName(string WsName)
        {
            var query = QueryFormatter.SelectFormatter.Get("id", "workshops", "name='" + WsName + "'");
            query = SelectFormatter.Get("id", "sectors", query, "workshop_id");
            return SelectFormatter.Get("tech_id", "masters", query, "sec_id");
        }

        public static string GetTechIdBySecName(string secName)
        {
            var query = SelectFormatter.Get("id", "sectors", "name='" + secName + "'");
            return SelectFormatter.Get("tech_id", "masters", query, "sec_id");
        }

        public static string GetWorkIdBySecName(string secName)
        {
            var query = SelectFormatter.Get("id", "sectors", "name='" + secName + "'");
            query = SelectFormatter.Get("id", "jobs", query, "sec_id");
            query=SelectFormatter.Get("team_id", "products_jobs", query,"job_id");
            return SelectFormatter.Get("id", "workers", query, "team_id");
        }


        public static string GetProdIdBySecName(string secName,ProdChoosenMode mode, string timeBeg, string timeEnd)
        {
            var query = QueryFormatter.SelectFormatter.Get("id", "sectors", "name='" + secName+ "'");
            query= QueryFormatter.SelectFormatter.Get("id", "jobs", query,"sec_id");
            var conditionLs = new List<string>();
            AddConditionsByMode(conditionLs, mode,timeBeg,timeEnd);
            conditionLs.Add(QueryFormatter.In("job_id",query));
            return QueryFormatter.SelectFormatter.Get("prod_id", "products_jobs", conditionLs);
        }

        public static string GetProdIdByMode(ProdChoosenMode mode, string timeBeg, string timeEnd)
        {
            if(mode == ProdChoosenMode.ProdType)
            {
                return QueryFormatter.SelectFormatter.Get("id", "products");
            }
            else
            {
                var conditionLs = new List<string>();
                AddConditionsByMode(conditionLs, mode,timeBeg,timeEnd);   
                return QueryFormatter.SelectFormatter.Get("prod_id", "products_jobs", conditionLs); 
            }
        }

        private static void AddConditionsByMode(List <string> conditions,ProdChoosenMode mode, string timeBeg, string timeEnd)
        {
            switch (mode)
            {
                case ProdChoosenMode.Assembled:
                    conditions.Add("time_end<=to_date('" + timeEnd + "','dd.mm.yyyy')");
                    conditions.Add("time_begin>=to_date('" + timeBeg + "','dd.mm.yyyy')");
                    break;
                case ProdChoosenMode.Assembling:
                    conditions.Add("time_end is null");
                    conditions.Add("time_begin<=to_date(TO_CHAR(SYSDATE, 'DD.MM.YYYY'),'dd.mm.yyyy')");
                    break;
            }
        }


        public static string GetJobsByProductName(string prodName)
        {
            var query=SelectFormatter
                    .Union(new List<string> { "name", "prod_id" }
                    , new List<string> { "rockets", "gliders", "hang_gliders", "helicopters", "planes", "other_prods" });
            query = SelectFormatter.Get("prod_id", "(" + query + ")","name='"+prodName+"'");
            query=SelectFormatter.Get("job_id", "products_jobs",query,"prod_id" );
            return SelectFormatter.Get("name","jobs",query,"id");
        }

        public static string GetWorkersIdBySecName(string secName)
        {
            var query = SelectFormatter.Get("id"
                , "sectors"
                , "name='" + secName + "'");

            query=SelectFormatter.Get("id", "jobs", query, "sec_id");
            query= SelectFormatter.Get("team_id", "products_jobs", query, "job_id");
            return SelectFormatter.Get(new List<string> { "first_name"
                            ,"last_name"
                            ,"patronymic" }, "workers", query, "team_id");
        }

        public static string GetSquadByWsName(string WsName)
        {
            var query = SelectFormatter.Get("id", "workshops", "name='" + WsName + "'");
            query = SelectFormatter.Get("id", "products", query, "workshop_id");
            query = SelectFormatter.Get("team_id", "products_jobs", query, "prod_id");
            query = SelectFormatter.Get(new List<string> { "id", "name" }, "teams", query, "id");
            var workersQuery = SelectFormatter.Get(new List<string> { "first_name", "last_name", "patronymic", "team_id" }, "workers");
            query = Join(workersQuery, query, new List<string> { "team_id=id" }, "t1", "t2");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic"
                ,"name as название_команды"},"("+query+")");
        }

        public static string GetSquadBySecName(string secName)
        {
            var query = SelectFormatter.Get("id", "sectors", "name='" + secName + "'");
            query = SelectFormatter.Get("id", "jobs", query, "sec_id");
            query = SelectFormatter.Get("team_id", "products_jobs", query, "job_id");
            query = SelectFormatter.Get(new List<string> { "id", "name" }, "teams", query, "id");
            var workersQuery = SelectFormatter.Get(new List<string> { "first_name", "last_name", "patronymic", "team_id" }, "workers");
            query = Join(workersQuery, query, new List<string> { "team_id=id" }, "t1", "t2");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic"
                ,"name as название_команды"}, "(" + query + ")");
        }

        public static string GetSquad()
        {
            var query = SelectFormatter.Get(new List<string> { "id" ,"name"}, "teams");
            var workersQuery = SelectFormatter.Get(new List<string> { "first_name", "last_name", "patronymic", "team_id" }, "workers");
            query = Join(workersQuery, query, new List<string> { "team_id=id" }, "t1", "t2");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic"
                ,"name as название_команды"}, "(" + query + ")");
        }

        public static string GetMastersByWsName(string WsName)
        {
            var query = SelectFormatter.Get("id", "workshops", "name='" + WsName + "'");
            query = SelectFormatter.Get("id", "sectors", query, "workshop_id");
            query = SelectFormatter.Get("tech_id","masters",query,"sec_id");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic" }, "technics", query, "id");
        }

        public static string GetMastersBySecName(string secName)
        {
            var query = SelectFormatter.Get("id", "sectors","name='"+secName+"'");
            query = SelectFormatter.Get("tech_id", "masters", query, "sec_id");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic" }, "technics", query, "id");
        }

        public static string GetMasters()
        {
            var query = SelectFormatter.Get("tech_id", "masters");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic" }, "technics", query, "id");
        }

        public static string GetLeadWs()
        {
            var query= SelectFormatter.Get("lead_id", "workshops");
            return SelectFormatter.Get(new List<string> { "first_name"
                , "last_name"
                , "patronymic" }, "technics", query, "id");
        }

        public static string GetTeamsAssembling(string prodName)
        {
            var query = SelectFormatter
                   .Union(new List<string> { "name", "prod_id" }
                   , new List<string> { "rockets", "gliders", "hang_gliders", "helicopters", "planes", "other_prods" });
            query = SelectFormatter.Get("prod_id", "(" + query + ")", "name='" + prodName + "'");
            var conditions = new List<string>
            {
                In("prod_id", query),
                "time_end is null",
                "time_begin<=to_date(TO_CHAR(SYSDATE, 'DD.MM.YYYY'),'dd.mm.yyyy')"
            };
            query = SelectFormatter.Get("team_id", "products_jobs", conditions);
            var teamQuery = SelectFormatter.Get(new List<string> { "name", "id" }
                , "teams", query, "id");
            query = SelectFormatter
                            .Get(new List<string>{"first_name"
                                ,"last_name","patronymic" ,"team_id"}, "workers"
                                ,query,"team_id");
            query = Join(teamQuery,query,new List<string> { "id=team_id" },"t1"
                ,"t2");
            return SelectFormatter.Get(new List<string>{"first_name"
                                ,"last_name","patronymic","name as name_team" }, "("+query+")");

        }

        public static string GetLabsListByProduct(string prodName)
        {
            var query = SelectFormatter
                   .Union(new List<string> { "name", "prod_id" }
                   , new List<string> { "rockets", "gliders", "hang_gliders", "helicopters", "planes", "other_prods" });
            query = SelectFormatter.Get("prod_id", "(" + query + ")", "name='" + prodName + "'");
            query = SelectFormatter.Get("exp_id", "products_exps", query, "prod_id");
            query = SelectFormatter.Get("tool_id", "exp_tools", query, "exp_id");
            query = SelectFormatter.Get("lab_id", "tools", query, "id");
            return SelectFormatter.Get("name", "laboratories", query, "id");
        }

        public static string GetProdIdByLaboratory(string labName,string dateStart,string dateEnd)
        {
            var query = SelectFormatter.Get("id","laboratories","name='"+labName+"'");
            query = SelectFormatter.Get("id","tools",query,"lab_id");
            query = SelectFormatter.Get("exp_id", "exp_tools", query, "tool_id");
            var conditions = new List<string>
            {
                In("exp_id", query),
                "time_end<=to_date('" + dateEnd + "','dd.mm.yyyy')",
                "time_begin>=to_date('" + dateStart + "','dd.mm.yyyy')"
            };
            return SelectFormatter.Get("prod_id", "products_exps", conditions);
        }

        public static string GetProdIdByProductName(string prodName)
        {
            var query = SelectFormatter
                   .Union(new List<string> { "name", "prod_id" }
                   , new List<string> { "rockets", "gliders", "hang_gliders"
                   , "helicopters", "planes", "other_prods" });
            return SelectFormatter.Get("prod_id", "(" + query + ")", "name='" + prodName + "'");
        }

        public static string GetWorkshops()=>
            SelectFormatter.Get("name", "workshops");

        public static string GetLaboratories()=>
            SelectFormatter.Get("name", "laboratories");

        public static string GetToolsByProdIdLab(string prodId,string labName) {
            var queryProd = SelectFormatter.Get("exp_id","products_exps",prodId,"prod_id");
            queryProd = SelectFormatter.Get("tool_id", "exp_tools", queryProd, "exp_id");
            queryProd = SelectFormatter.Get("name", "tools", queryProd, "lab_id");

            var queryLab = SelectFormatter.Get("id", "laboratories", "name='" + labName + "'");
            queryLab = SelectFormatter.Get("name" , "tools", queryLab, "lab_id");

            var query=QueryFormatter.Join(queryLab,queryProd,new List<string> { "name=name" },"t1","t2");
            return SelectFormatter.Get("t1.name", "(" + query + ")");
        }

        public static string GetInvestigatorsByProduct(string subQuery,string dateStart
            ,string dateEnd)
        {
            var query = SelectFormatter.Get("prod_id", "(" + subQuery + ")");
            var conditions = new List<string>
            {
                In("prod_id", query),
                "time_end<=to_date('" + dateEnd + "','dd.mm.yyyy')",
                "time_begin>=to_date('" + dateStart + "','dd.mm.yyyy')"
            };
            query = SelectFormatter.Get("exp_id", "products_exps", conditions);
            return SelectFormatter.Get(new List<string>{"first_name"
                , "last_name"
                , "patronymic"}, "investigators", query, "exp_id");
        }

        public static string GetSectorByFactory()
        {
            var query = SelectFormatter.Get(new List<string> { "name","tech_id" },"sectors");
            var technicsQuery= SelectFormatter.Get(new List<string> { "first_name"
                , "last_name","patronymic","id" }, "technics");
            query=LeftOuterJoin(query, technicsQuery, new List<string> { "tech_id=id" }, "t1", "t2");
            return SelectFormatter.Get(new List<string> { "first_name"
            , "last_name","patronymic","name"}, "(" + query + ")");
        }

        public static string GetSectorByWorkshopName(string WsName)
        {
            var query= SelectFormatter.Get("id", "workshops","name='"+WsName+"'");
            query = SelectFormatter.Get(new List<string> { "name", "tech_id" }, "sectors"
                ,query,"workshop_id");
            var technicsQuery = SelectFormatter.Get(new List<string> { "first_name"
                , "last_name","patronymic","id" }, "technics");
            query = Join(query, technicsQuery, new List<string> { "tech_id=id" }, "t1", "t2");
            return SelectFormatter.Get(new List<string> { "first_name"
            , "last_name","patronymic","name"}, "(" + query + ")");
        }
    }
}
