namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();

            string inputLine; 
            while ((inputLine = Console.ReadLine()) != "Tournament")
            {
                var inputInfo = inputLine.Split(' ');
                var trainerName = inputInfo[0];
                var pokemonName = inputInfo[1];
                var pokemonElement = inputInfo[2];
                var pokemonHealth = int.Parse(inputInfo[3]);

                if (trainers.Count == 0)
                {
                    var trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(trainer);
                    continue;
                }

                var isContained = false;
                foreach (var tr in trainers)
                {
                    if (trainerName == tr.Name)
                    {
                        tr.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                        isContained = true;
                        break;
                    }
                }

                if (!isContained)
                {
                    var trainer = new Trainer(trainerName);
                    var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
            }

            while ((inputLine = Console.ReadLine()) != "End")
            {
                var givenElement = inputLine;

                foreach (var tr in trainers)
                {
                    tr.CheckForCurrentPokemonElement(givenElement);
                }
            }

            foreach (var tr in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{tr.Name} {tr.Badges} {tr.Pokemons.Count}");
            }
        }
    }
}
