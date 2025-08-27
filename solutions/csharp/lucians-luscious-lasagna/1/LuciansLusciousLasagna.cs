class Lasagna
{
    // Defines how many minutes the lasagna should be in the oven
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // Calculates remaining oven time
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return ExpectedMinutesInOven() - actualMinutesInOven;
    }

    // Preparation time is 2 minutes per layer
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // Total working time is preparation + time in oven
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }
}
