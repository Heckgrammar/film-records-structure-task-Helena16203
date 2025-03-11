namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
                public string title;
                public string certificate;
                public int year;
                public bool beingShown;

                public Film(string title, string certificate, int year, bool beingShown)
                {
                    this.title = title;
                    this.certificate = certificate;
                    this.year = year;
                    this.beingShown = beingShown;
                }
            }
            static void Main(string[] args)
            {
                Film hulk = new Film("Hulk", "12A", 2005, false);
                Film ironMan = new Film("Iron Man", "12A", 2008, false);
                Film antMan = new Film("Ant-Man", "12A", 2015, false);
                Film[] filmCollection = new Film[] { antMan, hulk, ironMan };
                int year = 0;
                int position = 0;
                
                Film newestFilm = filmCollection[0];
                for (int i = 1; i < filmCollection.Length; i++)
                {
                    if (filmCollection[i].year > newestFilm.year)
                    {
                        newestFilm = filmCollection[i];
                    }
                }
                Console.WriteLine("The newest film is: " + newestFilm.title);

                // Update the AntMan record to show the film is currently being shown
                for (int i = 0; i < filmCollection.Length; i++)
                {
                    if (filmCollection[i].title == "Ant-Man")
                    {
                        filmCollection[i].beingShown = true;
                    }
                }

                // Check the update for AntMan
                foreach (var film in filmCollection)
                {
                    if (film.title == "Ant-Man")
                    {
                        Console.WriteLine("Title: " + film.title + " Being Shown: " + film.beingShown);
                    }
                }
            }
        }
    }
 }
