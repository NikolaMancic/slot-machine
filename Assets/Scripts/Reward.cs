public class Reward
{
    public Reward(int steakMultiplier, int numberOfCoins)
    {
        SteakMultiplier = steakMultiplier;
        NumberOfCoins = numberOfCoins;
    }

    public int SteakMultiplier { get; }
    public int NumberOfCoins { get; }
}
