using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class Music
    {
        private string _title;
        private string _artist;
        private int _duration;
        private int _yearOfPublication;

        public Music()
        {

        }

        public Music(string title, string artist, int duration, int yearOfPublication)
        {
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public int YearOfPublication
        {
            get => _yearOfPublication;
            set => _yearOfPublication = value;
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Duration)}: {Duration}, {nameof(YearOfPublication)}: {YearOfPublication}";
        }
    }
}
