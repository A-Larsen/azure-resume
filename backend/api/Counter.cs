using Newtonsoft.Json;

// JSON Counter
namespace My.Functions
{
   public class Counter
   {
        [JsonProperty(PropertyName = "id")]
        public string Id {get; set;}

        [JsonProperty(PropertyName = "count")]
        public int Count {get; set;}
   } 
}
