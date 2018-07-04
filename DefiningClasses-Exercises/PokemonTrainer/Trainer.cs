namespace PokemonTrainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return this.name; }
        }

        public int Badges
        {
            get { return this.badges; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }

        public Trainer(string name)
        {
            this.name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public void CheckForCurrentPokemonElement(string givenElement)
        {
            var isContained = false;
            foreach (var pokemon in this.pokemons)
            {
                if (pokemon.Element == givenElement)
                {
                    this.badges++;
                    isContained = true;
                    break;
                }
            }

            if (!isContained)
            {
                for (int i = 0; i < this.pokemons.Count; i++)
                {
                    this.pokemons[i].Health -= 10;

                    if (this.pokemons[i].Health <= 0)
                    {
                        this.pokemons.Remove(this.pokemons[i]);
                    }
                }
            }
        }
    }
}
