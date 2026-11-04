class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public  int ExpectedMinutesInOven()
    {
     int ExpectedMinutesInOven = 40;
     return ExpectedMinutesInOven;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public  int RemainingMinutesInOven(int time)
    { 
    int RemainingMinutesInOven = ExpectedMinutesInOven() - time;    
    return RemainingMinutesInOven;
    }   
    // TODO: define the 'PreparationTimeInMinutes()' method
    public  int PreparationTimeInMinutes(int layers)
    {
        int TimePerLayer = 2;
        int PreparationTimeInMinutes = layers * TimePerLayer;
        return PreparationTimeInMinutes;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer,int time){
        int TimePerLayer = 2;
        int TotalTimePerLayer = layer * TimePerLayer;
        int ElapsedTimeInMinutes = TotalTimePerLayer + time;
        return ElapsedTimeInMinutes;
    }
}
