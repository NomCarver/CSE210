class Card
{
    public int cardValue;
    // generates a random number between 1 and 13
    public void getNewCard()
    {
        Random randomGenerator = new Random();
        cardValue = randomGenerator.Next(1,14);
    }
}