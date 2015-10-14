using System.Collections.Generic;
using System.Linq;

namespace JsonData
{
    public abstract class JObject
    {
        public class Object : JObject
        {
            public Dictionary<string, JObject> Properties { get; set; }

            public override string ToString()
            {
                return $"{{{string.Join(" ,", Properties.Select(p => $"{p.Key}: {p.Value.ToString()}"))}}}";
            }
        }

        public class Array : JObject
        {
            public List<JObject> Items { get; set; }

            public override string ToString()
            {
                return $"[{string.Join(" ,", Items.Select(i => i.ToString()))}]";
            }
        }

        public class Value : JObject
        {
            public JValue Data { get; set; }

            public override string ToString()
            {
                return Data.ToString();
            }
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
