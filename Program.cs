namespace Dag_14_ovn_8
{
    internal class Program
    { }
    class Land
    {
        public string namn, styrestyp, huvudstad, invånartal;

        static void Main(string[] args)
        {
            Land sverige = new Land { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånartal = "10512820" };
            Land tyskland = new Land { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånartal = "83783902" };
            Land sanMarino = new Land { namn = "SanMarino", styrestyp = "republik", huvudstad = "SanMarino", invånartal = "33600" };
        }
    }
}