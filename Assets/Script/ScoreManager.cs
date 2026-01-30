using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0;

    public void Score(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }
}