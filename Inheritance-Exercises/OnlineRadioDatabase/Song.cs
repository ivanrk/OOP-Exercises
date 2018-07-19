namespace OnlineRadioDatabase
{
    using System;

    public class Song
    {
        private const int ART_NAME_MIN_LENGTH = 3;
        private const int ART_NAME_MAX_LENGTH = 20;

        private string artistName;
        private string songName;
        private string songLength;

        public Song(string artistName, string songName, string songLength)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongLength = songLength;
        }

        public string ArtistName
        {
            get { return this.artistName; }
            private set
            {
                if (value.Length < ART_NAME_MIN_LENGTH || value.Length > ART_NAME_MAX_LENGTH)
                {
                    throw new ArgumentException($"Artist name should be between {ART_NAME_MIN_LENGTH} and {ART_NAME_MAX_LENGTH} symbols.");
                }
                this.artistName = value;
            }
        }
    }
}
