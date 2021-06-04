using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DevineLeNombre
{
    internal class Program
    {
        private static List<PlayerScore> scores;
        private static int difficulte;

        private static void Main(string[] args)
        {
            AfficherMeilleursScores();
            int borneMaximum = ObtenirBorneMaximum();
            System.Console.WriteLine("Choisir le niveau de difficulté (1 = facile, 2 = moyen, 3 = difficile)");
            int nbEssais = 5;
            if (int.TryParse(Console.ReadLine(), out difficulte))
            {
                nbEssais = difficulte switch
                {
                    1 => 10,
                    2 => 5,
                    3 => 3,
                    _ => 5
                };
            }
            JouerJeu(borneMaximum, nbEssais);
        }

        private static void JouerJeu(int borneMaximum, int nbEssais)
        {
            string saisie = "";
            var random = new Random();
            var nombre = random.Next(0, borneMaximum + 1);
            bool? etatJeu = null;
            List<int> tentatives = new List<int>();
            while (!etatJeu.HasValue)
            {
                Console.Clear();
                Console.WriteLine("Chiffres déjà joués : " + string.Join(", ", tentatives));
                Console.WriteLine("Tentez de deviner le nombre caché");
                saisie = Console.ReadLine();
                if (saisie == "q")
                {
                    Environment.Exit(0);
                }
                if (int.TryParse(saisie, out int devine))
                {
                    tentatives.Add(devine);
                    if (devine == nombre)
                    {
                        etatJeu = true;
                        break;
                    }
                    else if (devine > nombre)
                    {
                        Console.WriteLine("Le nombre à deviner est plus petit");
                    }
                    else
                    {
                        Console.WriteLine("Le nombre à deviner est plus grand");
                    }
                    if (tentatives.Count >= nbEssais)
                    {
                        etatJeu = false;
                        break;
                    }
                }
                System.Console.WriteLine("Appuyer sur Entrée pour continuer");
                Console.ReadLine();
            }
            if (etatJeu.HasValue)
            {
                if (etatJeu.Value)
                {
                    System.Console.WriteLine("Gagné !");
                    VerifierScorePourPalmares(borneMaximum, nbEssais, tentatives.Count);
                }
                else
                {
                    System.Console.WriteLine("Perdu ! Le nombre à deviner était " + nombre);
                }
            }
        }

        private static void VerifierScorePourPalmares(int borneMaximum, int nbEssais, int tentatives)
        {
            var playerScore = borneMaximum + ((nbEssais - tentatives) ^ difficulte);
            if (scores.Count == 0)
            {
                AddPlayerScore(playerScore);
            }
            else if (scores.Count == 5)
            {
                if (scores.Min(s => s.Score < playerScore))
                {
                    AddPlayerScore(playerScore);
                }
            }
            else
            {
                if (scores.Min(s => s.Score <= playerScore))
                {
                    AddPlayerScore(playerScore);
                }
            }
            int position = 1;
            foreach (var score in scores.OrderByDescending(s => s.Score))
            {
                score.Position = position;
                position++;
            }
            File.WriteAllText("scores.json", JsonSerializer.Serialize(scores.Take(5)));
        }

        private static void AddPlayerScore(int playerScore)
        {
            Console.WriteLine("Saisissez votre nom pour être inscrit au tableau");
            string playerName = Console.ReadLine();
            var score = new PlayerScore
            {
                PlayerName = playerName,
                Score = playerScore
            };
            scores.Add(score);
        }

        private static int ObtenirBorneMaximum()
        {
            int borneMaximum = 0;
            string saisie = string.Empty;
            do
            {
                Console.WriteLine("Saisir la borne maximum du chiffre à deviner");
                saisie = Console.ReadLine();
                if (saisie == "q")
                {
                    Environment.Exit(0);
                }
            } while (!int.TryParse(saisie, out borneMaximum) && borneMaximum <= 0);
            return borneMaximum;
        }

        private static void AfficherMeilleursScores()
        {
            var scoreFile = "scores.json";
            string json = "";
            if (File.Exists(scoreFile))
            {
                json = File.ReadAllText(scoreFile);
            }
            if (!string.IsNullOrWhiteSpace(json))
            {
                scores = JsonSerializer.Deserialize<List<PlayerScore>>(json);
                System.Console.WriteLine("Tableaux des meilleurs joueurs");
                foreach (var score in scores.OrderBy(s => s.Position))
                {
                    System.Console.WriteLine(score.Position + " - " + score.PlayerName + " : " + score.Score);
                }
            }
            else
            {
                scores = new List<PlayerScore>();
            }
        }
    }
}
