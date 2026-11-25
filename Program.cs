namespace Pokemon;
/*
    CONSIGNES
    1. Déclarer un tableau contenant les six Pokémon suivants :
       - Pikachu
       - Dracaufeu
       - Tortank
       - Florizarre
       - Ectoplasma
       - Ronflex
   2. Utiliser une boucle for pour parcourir le tableau.
   3. Afficher chaque Pokémon avec sa position dans l'équipe.
   4. Afficher le nombre total de Pokémon.
*/
class Program
{
    static void Pokemon()
    {
        string[] pokemon = { "Pikachu", "Dracaufeu", "Tortank", "Florizarre", "Ectoplasma", "Ronflex" };
        for (int i = 0; i < pokemon.Length; i++)
        {
            Console.WriteLine( i+1 + " position " + pokemon[i]/*System.Array.IndexOf(pokemon, pokemon[i])*/);
        }
        Console.WriteLine(pokemon.Length + " Pokemon en tout.");
    }
    
    static void Main(string[] args)
    {
        Pokemon();
    }
}