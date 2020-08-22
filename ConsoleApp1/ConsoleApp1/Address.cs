namespace ConsoleApp1
{
    public class Address
    {
        public string address;
        public int num;

        public Address(string address, int num)
        {
            this.address = address;
            this.num = num;
        }

        public override bool Equals(object obj)
        {
            return address == ((Address)obj).address
             && num == ((Address)obj).num;
        }
    }
}