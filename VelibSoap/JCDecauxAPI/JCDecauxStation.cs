namespace JCDecauxAPI
{
    public class JCDecauxStation
    {
        public int number;
        public string name;
        public string address;
        public string contract_name;
        public int bike_stands;
        public int available_bike_stands;
        public int available_bikes;

        public override string ToString()
        {
            return name;
        }
    }
}