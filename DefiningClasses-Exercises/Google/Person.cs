namespace Google
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        public Person()
        {
            this.pokemons = new List<Pokemon>();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }

        public Person(string name) : this()
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }
    }
}
