using System;
using UnityEngine;


public static class EventBus
{
    
    public static event Action<int> OnScoreChanged;
    public static event Action<string> OnDivisionUpgrade;


    public static void PublishScoreChange(int newScore)
    {
        OnScoreChanged?.Invoke(newScore);
    }
    public static void PublishDivisionUpgrade(string division)
    {
        OnDivisionUpgrade?.Invoke(division);
    }
}






