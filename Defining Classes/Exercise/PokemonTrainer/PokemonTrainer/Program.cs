namespace PokemonTrainer;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Trainer> trainerByName = new Dictionary<string, Trainer>();

        string input = Console.ReadLine();

        while (input != "Tournament")
        {
            string[] data = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            string trainerName = data[0];
            if (!trainerByName.ContainsKey(trainerName))
                trainerByName[trainerName] = new Trainer(trainerName);

            Pokemon pokemon = new Pokemon { 
                Name = data[1], 
                Element = data[2], 
                Health = int.Parse(data[3])
            };
            trainerByName[trainerName].Pokemons.Add(pokemon);

            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "End")
        {
            foreach (Trainer trainer in trainerByName.Values)
                GamePlay(trainer, input);

            input = Console.ReadLine();
        }

        foreach (Trainer trainer in trainerByName.Values.OrderByDescending(t => t.Badges))
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
    }

    private static void GamePlay(Trainer trainer, string element)
    {
        if (trainer.Pokemons.Any(p => p.Element == element))
            trainer.Badges++;
        else
        {
            for (int i = trainer.Pokemons.Count - 1; i >= 0; i--)
            {
                trainer.Pokemons[i].Health -= 10;

                if (trainer.Pokemons[i].Health <= 0)
                    trainer.Pokemons.RemoveAt(i);
            }
        }
    }
}

