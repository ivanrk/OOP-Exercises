namespace Google
{
    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string birthday)
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
