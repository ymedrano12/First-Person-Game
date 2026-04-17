using UnityEngine;
using TMPro;


public class ScoreUI : MonoBehaviour
{
    private int Score = 0;
    [SerializeField] private TextMeshProUGUI text; 
    public void IncreaseScore()
    {
        Score++;
        Debug.Log("Score: " + Score);
        text.text = "Score: " + Score;

        if (Score >= 4)
        {
            Debug.Log("All weapons found");
        }
    }

}
