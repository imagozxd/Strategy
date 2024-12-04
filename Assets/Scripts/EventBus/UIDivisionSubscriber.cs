using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDivisionSubscriber : MonoBehaviour
{
    [SerializeField] private TMP_Text divisionText;
    [SerializeField] private Image divisionMedalImage;
    [SerializeField] private Sprite bronzeMedal;
    [SerializeField] private Sprite silverMedal;
    [SerializeField] private Sprite goldMedal;
    [SerializeField] private Sprite plateMedal;


    private void OnEnable()
    {
        EventBus.OnDivisionUpgrade += ShowDivisionUpgrade;
    }

    private void OnDisable()
    {
        EventBus.OnDivisionUpgrade -= ShowDivisionUpgrade;
    }

    private void ShowDivisionUpgrade(string newDivision)
    {
        divisionText.text = "¡Ascendiste a "+newDivision+"!";

        switch (newDivision)
        {
            case "Bronce":
                divisionMedalImage.sprite = bronzeMedal;
                break;
            case "Plata":
                divisionMedalImage.sprite = silverMedal;
                break;
            case "Oro":
                divisionMedalImage.sprite = goldMedal;
                break;
            case "Platinito":
                divisionMedalImage.sprite = plateMedal;
                break;
        }
            
    }
}







