using System;
using Newtonsoft.Json;

namespace backend1.Model
{ 
    public class Person 
    { 
        [JsonProperty(PropertyName = "PersonID")]
        public int Id {get; set;}
        [JsonProperty(PropertyName = "Firstname")]
        public string FirstName {get; set;}
        [JsonProperty(PropertyName = "Lastname")]
        public string LastName {get; set;} 
        public Person() {}

    }
}