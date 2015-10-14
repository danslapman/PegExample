using System.Collections.Generic;

namespace JsonData
{
    public abstract class JObject
    {
        public class Object : JObject
        {
            public Dictionary<string, JObject> Properties { get; set; } 
        }

        public class Array : JObject
        {
            public List<JObject> Items { get; set; } 
        }

        public class Value : JObject
        {
            public JValue Data { get; set; }
        }

        public static Object CreateObject()
        {
            return new Object {Properties = new Dictionary<string, JObject>()};
        }

        public static Array CreateArray()
        {
            return new Array {Items = new List<JObject>()};
        }

        public static Value CreateValue(JValue value)
        {
            return new Value {Data = value};
        }
    }
}
