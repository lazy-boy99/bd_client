using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Model
{
    public static class RoleManager
    {

        

        public enum RoleType
        {
            DirectorWorkers,
            DirectorProduction,
            DirectorTechnics,
            DirectorScientists,
            Scientist,
            Director,
            EquipmentManager,
            DirectorWorkshop,
            DirectorSector
        }

        public static string ToString(RoleType type) =>
            type switch
            {
                RoleType.Director => "Директор",
                RoleType.DirectorProduction => "Директор по производству",
                RoleType.DirectorScientists => "Директор научного персонала",
                RoleType.DirectorSector => "Начальник участка",
                RoleType.DirectorTechnics => "Директор технического персонала",
                RoleType.DirectorWorkers => "Директор рабочего персонала",
                RoleType.DirectorWorkshop => "Начальник цеха",
                RoleType.Scientist => "Научный сотрудник",
                RoleType.EquipmentManager => "Ответственный за лабораторное оборудование",
                _ => throw new NotImplementedException("name of type is null!!")
            };


        public static RoleType GetType(string name) =>
            name switch
            {
                "Директор" => RoleType.Director,
                "Директор по производству" => RoleType.DirectorProduction,
                "Директор научного персонала" => RoleType.DirectorScientists,
                "Начальник участка" => RoleType.DirectorSector,
                "Директор технического персонала" => RoleType.DirectorTechnics,
                "Директор рабочего персонала" => RoleType.DirectorWorkers,
                "Начальник цеха" => RoleType.DirectorWorkshop,
                "Научный сотрудник" => RoleType.Scientist,
                "Ответственный за лабораторное оборудование" => RoleType.EquipmentManager,
                _ => throw new NotImplementedException("name of type is null!!")
            };
    }
}
