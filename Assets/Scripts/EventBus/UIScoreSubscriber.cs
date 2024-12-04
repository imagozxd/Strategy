using UnityEngine;
using TMPro;

public class UIScoreSubscriber : MonoBehaviour
{
    public TMP_Text scoreText;
    private void OnEnable()
    {
        EventBus.OnScoreChanged += UpdateScoreUI;
    }

    private void OnDisable()
    {
        EventBus.OnScoreChanged -= UpdateScoreUI;
    }

    private void UpdateScoreUI(int newScore)
    {
        scoreText.text = "Puntos: "+newScore;
    }
}






