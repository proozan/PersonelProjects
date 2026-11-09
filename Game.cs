public class Game


{
    public string Name { get; set; }
    public string ImagePath { get; set; }
    public int Score { get; set; }

    public override string ToString()
    {
        return $"{Name} - Score: {Score}/10";
    }
}