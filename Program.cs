namespace Dag_14_ovn_8
{
    internal class Program
    { }
    class Land
    {
        public string namn, styrestyp, huvudstad, invånartal;

        public void Print() { Console.WriteLine("Land: "+  namn + "Styrestyp: " + styrestyp + "Huvudstad: " + huvudstad + "Invånaral: " + invånartal); }

        static void Main(string[] args)
        {
            Land sverige = new Land { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånartal = "10512820" };
            Land tyskland = new Land { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånartal = "83783902" };
            Land sanMarino = new Land { namn = "SanMarino", styrestyp = "republik", huvudstad = "SanMarino", invånartal = "33600" };
            sverige.Print();

            Land[] lander = new Land[7] { sverige, tyskland, sanMarino, null, null, null, null };
            lander[4] = new Land { namn = "Danmark", styrestyp = "monarki", huvudstad = "Köpenhamn", invånartal = "5928364" };
            lander[4] = new Land { namn = "Italien", styrestyp = "republik", huvudstad = "Rom", invånartal = "58853482" };
            lander[4] = new Land { namn = "Danmark", styrestyp = "republik", huvudstad = "Prag", invånartal = "10551219" };
            lander[4] = new Land { namn = "Danmark", styrestyp = "republik", huvudstad = "Bukarest", invånartal = "19760314" };
        }
    }
}