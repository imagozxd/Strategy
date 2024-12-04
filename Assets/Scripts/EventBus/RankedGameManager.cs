using System;
using UnityEngine;
public class RankedGameManager : MonoBehaviour
{
    private int currentPoints = 1000;
    private string currentDivision = "Hierro";

    public void SimulateWin()
    {
        int pointsPerWin = 20; 
        currentPoints += pointsPerWin;
                
        EventBus.PublishScoreChange(currentPoints);

        CheckDivisionUpgrade();
    }

    private void CheckDivisionUpgrade()
    {
        if (currentPoints >= 1100 && currentDivision == "Hierro")
        {
            currentDivision = "Bronce";
            //Debug.Log("funca desde aca " +currentDivision);
            EventBus.PublishDivisionUpgrade(currentDivision);
        }
        else if (currentPoints >= 1200 && currentDivision == "Bronce")
        {
            currentDivision = "Plata";            
            EventBus.PublishDivisionUpgrade(currentDivision);
        }
        else if (currentPoints >= 1300 && currentDivision == "Plata")
        {
            currentDivision = "Oro";
            EventBus.PublishDivisionUpgrade(currentDivision);
        }
        else if (currentPoints >= 1400 && currentDivision == "Oro")
        {
            currentDivision = "Platinito";
            EventBus.PublishDivisionUpgrade(currentDivision);
        }

    }
}





