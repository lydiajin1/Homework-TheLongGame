namespace Homework_TheLongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! What's your name?");
            string username = Console.ReadLine();

            // create a file path to store and retrieve player's score 
            string filePath = username + ".txt";

            // initialize score 
            int score = 0; 

            if (File.Exists(filePath))
            {
                //loads previous score if file exists 
                score = int.Parse(File.ReadAllText(filePath));
                Console.WriteLine("Hey " + username + "!" + " Welcome back! Your srarting score is " + score);
            }
            
            // key press to track score 
            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }

                score++;
                Console.WriteLine("Current score: " + score);
            }

            // saving the score 
            File.WriteAllText(filePath, score.ToString());

            Console.WriteLine("Game Over! This is your final score " + score + " !");
        }
    }
}
