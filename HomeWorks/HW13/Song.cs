using System;

namespace HW13
{
    class Song
    {
        private string _title;
        private uint _minutes;
        private string _author;
        private uint _albumYear;
        private Genre _genre;

        public Song()
        {
            SetSongData();
        }

        static public object GetSongData(Song song)
        {
            var SongData = new
            {
                Title = song._title,
                Minutes = song._minutes,
                Author = song._author,
                AlbumYear = song._albumYear,
                MusicGenre = song._genre
            };
            return SongData;
        }

        private void SetSongData()
        {
            _title = SetTitle();
            _minutes = SetMinutes();
            _author = SetAuthor();
            _albumYear = SetAlbumYear();
            _genre = SetGenre();
        }

        private string SetTitle()
        {
            Console.WriteLine("Enter the title of the song:");
            return Console.ReadLine();
        }

        private uint SetMinutes()
        {
            Console.WriteLine("Enter the length of the song in minutes:");
            uint result;
            if (uint.TryParse(Console.ReadLine(), out result))
                return result;
            else
            {
                Console.WriteLine("Something wrong!");
                return SetMinutes();
            }
        }

        private string SetAuthor()
        {
            Console.WriteLine("Enter the author of the song:");
            return Console.ReadLine();
        }

        private uint SetAlbumYear()
        {
            Console.WriteLine("Enter the year of the song:");
            uint result;
            if (uint.TryParse(Console.ReadLine(), out result))
                return result;
            else
            {
                Console.WriteLine("Something wrong!");
                return SetAlbumYear();
            }
        }

        private Genre SetGenre()
        {
            Console.WriteLine("Enter the number of the genre of the song:");
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof(Genre)))
            {
                Console.WriteLine($"{counter}. {item}");
                counter += 1;
            }

            int userChoice;
            if (int.TryParse(Console.ReadLine(), out userChoice))
            {
                if (Enum.IsDefined(typeof(Genre), userChoice))
                    return (Genre)userChoice;
                else
                {
                    Console.WriteLine("Something wrong!");
                    return SetGenre();
                }
            }
            else
            {
                Console.WriteLine("Something wrong!");
                return SetGenre();
            }
        }
    }
}
