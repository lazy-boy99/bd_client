using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Model
{
    public static class Configuration
    {
        public enum ProdChoosenMode
        {
            Assembled,
            Assembling,
            ProdType
        }

        public enum ChoosenPlace
        {
            Factory,
            WorkShop,
            Sector
        }

        public enum CategoryProd
        {
            Rockets,
            Gliders,
            HangGliders,
            Planes,
            Helicopters,
            Other,
            ChooseProd,
            All
        }

        public enum CategoryWorkers
        {
            Welders,
            Turners,
            Fitters,
            Others,
            Collectors,
            All
        }

        public enum CategoryTechnics
        {
            Engineers,
            Technicians,
            Technologists,
            All
        }

        public static ChoosenPlace GetPlace(string name) =>
           name switch
           {
               "Цех" => ChoosenPlace.WorkShop,
               "Предприятие" => ChoosenPlace.Factory,
               "Участок" => ChoosenPlace.Sector,
               _ => throw new NotImplementedException("name of place is null!!")
           };

        public static ProdChoosenMode GetMode(string name) =>
            name switch
            {
                "Виды изделий" => ProdChoosenMode.ProdType,
                "Собраные изделия" => ProdChoosenMode.Assembled,
                "Собираемые изделия" => ProdChoosenMode.Assembling,
                _ => throw new NotImplementedException("name of mode is null!!")
            };

        public static CategoryProd GetCategoryProd(string name) =>
           name switch
           {
               "Все категории" => CategoryProd.All,
               "Ракеты" => CategoryProd.Rockets,
               "Самолеты" => CategoryProd.Planes,
               "Планеры" => CategoryProd.Gliders,
               "Вертолеты" => CategoryProd.Helicopters,
               "Дельтапланы" => CategoryProd.HangGliders,
               "Другая продукция" => CategoryProd.Other,
               "Указаная продукция"=>CategoryProd.ChooseProd,
               _ => throw new NotImplementedException("name of category is null!!")
           };

        public static CategoryWorkers GetCategoryWorkers(string name) =>
               name switch
               {
                   "Все профессии" => CategoryWorkers.All,
                   "Сборщики" => CategoryWorkers.Collectors,
                   "Слесари" => CategoryWorkers.Fitters,
                   "Прочие" => CategoryWorkers.Others,
                   "Токари" => CategoryWorkers.Turners,
                   "Сварщики" => CategoryWorkers.Welders,
                   _ => throw new NotImplementedException("name of category is null!!")
               };

        public static CategoryTechnics GetCategoryTechnics(string name) =>
               name switch
               {
                   "Все профессии" => CategoryTechnics.All,
                   "Инженеры" => CategoryTechnics.Engineers,
                   "Техники" => CategoryTechnics.Technicians,
                   "Технологи" => CategoryTechnics.Technologists,
                   _ => throw new NotImplementedException("name of category is null!!")
               };
    }

}
