namespace BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }

        public string Name { get; }

        public string BirthDate { get; }
    }
}
