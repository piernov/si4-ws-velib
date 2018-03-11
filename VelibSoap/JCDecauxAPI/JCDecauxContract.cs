using System.Collections.Generic;

namespace JCDecauxAPI
{
    public class JCDecauxContract
    {
        public string name;
        public List<string> cities;
        public string commercial_name;
        public string country_code;

        public override string ToString()
        {
            return name;
        }
    }
}