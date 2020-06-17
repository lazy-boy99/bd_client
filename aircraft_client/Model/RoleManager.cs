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
            Director,
            EquipmentManager
        }

        public static string ToString(RoleType type) =>
            type switch
            {
                RoleType.Director => "Директор",
                RoleType.DirectorProduction => "Директор по производству",
                RoleType.DirectorScientists => "Директор научного персонала",
                RoleType.DirectorTechnics => "Директор технического персонала",
                RoleType.DirectorWorkers => "Директор рабочего персонала",
                RoleType.EquipmentManager => "Ответственный за лабораторное оборудование",
                _ => throw new NotImplementedException("name of type is null!!")
            };


        public static RoleType GetType(string name) =>
            name switch
            {
                "Директор" => RoleType.Director,
                "Директор по производству" => RoleType.DirectorProduction,
                "Директор научного персонала" => RoleType.DirectorScientists,
                "Директор технического персонала" => RoleType.DirectorTechnics,
                "Директор рабочего персонала" => RoleType.DirectorWorkers,
                "Ответственный за лабораторное оборудование" => RoleType.EquipmentManager,
                _ => throw new NotImplementedException("name of type is null!!")
            };
    }
}
