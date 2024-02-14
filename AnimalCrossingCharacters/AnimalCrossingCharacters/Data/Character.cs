namespace AnimalCrossingCharacters.Data
{
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public string Quote { get; set; } = string.Empty;

        public Character(string name, string imageURL, string quote)
        { 
            Name = name;
            ImageURL = imageURL;
            Quote = quote;
        }
    }
}
