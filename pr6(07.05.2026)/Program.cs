using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pr6
{
    public class Movie
    {
        private string _name;
        private int _duration;
        private int[] _review;
        public string Name => _name;
        public int Duration => _duration;

        public int[] Review => _review.ToArray();
        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
            _review = new int[0];
        }
    }
    public class movieDTO
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string MovieType { get; set; }

        public movieDTO()
        {

        }

        public movieDTO(string name, int duration)
        {
            MovieType = nameof(Movie);
            Name = name;
            Duration = duration;
        }

        public movieDTO(Movie movie)
        {
            MovieType = movie.GetType().Name;
            Name = movie.Name;
            Duration = movie.Duration;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Harry Potter", 120);

            movieDTO movieDTO1 = new movieDTO(movie1.Name, movie1.Duration);

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "movie.xml");

            var serializer = new XmlSerializer(typeof(Movie));

            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, movieDTO1);

            }

            movieDTO movieDTO2;

            using (var reader = new StreamReader(filePath))
            {
                movieDTO2 = (movieDTO)serializer.Deserialize(reader);
            }


            Movie movie = new Movie(movieDTO2.Name, movieDTO2.Duration);
        }
    }
}