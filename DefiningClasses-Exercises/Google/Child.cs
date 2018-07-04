namespace Google
{
    public class Child
    {
        private string name;
        private string birthday;

        public Child(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}
