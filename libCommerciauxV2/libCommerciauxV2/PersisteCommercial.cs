using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace libCommerciauxV2
{
    public static class PersisteCommercial
    {
        public static void sauve(ServiceCommercial sc, string file)
        {
        string jsonString = JsonSerializer.Serialize(sc, new JsonSerializerOptions 
        { 
            WriteIndented = true
        });
        File.WriteAllText(file, jsonString);
        }

        public static ServiceCommercial Charge(string file)
        {
            string jsonString = File.ReadAllText(file);
            return JsonSerializer.Deserialize<ServiceCommercial>(jsonString);
        }
    }          
}