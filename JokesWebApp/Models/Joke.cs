namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeQnswer { get; set; }

        //ctor generate the constructor automatically pressing tab twice
        public Joke()
        {

        }
    }
}
