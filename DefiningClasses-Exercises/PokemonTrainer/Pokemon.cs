namespace PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;
        
        public string Name
        {
            get { return this.name; }
        }

        public string Element
        {
            get { return this.element; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
    }
}
