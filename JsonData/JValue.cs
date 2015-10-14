namespace JsonData
{
    public abstract class JValue
    {
        public class Null : JValue
        {
            
        }

        public class String : JValue 
        {
            public string Value { get; set; }
        }

        public static JValue CreateNull()
        {
            return new Null();
        }

        public static JValue CreateString(string value)
        {
            return new String {Value = value};
        }
    }
}
