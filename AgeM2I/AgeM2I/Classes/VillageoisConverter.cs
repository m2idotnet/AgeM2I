using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgeM2I.Classes
{
    public class VillageoisConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Villageois));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            JObject j = JObject.Load(reader);
            
            bool isR = ((string)j["Nom"] == "R");
           
            IVillageois s;
            if(isR)
            {
                s = new Roturier();
            }
            else
            {
                s = new Paysan();
            }
            serializer.Populate(j.CreateReader(), s);
            return s;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
