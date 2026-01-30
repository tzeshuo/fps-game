using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 500f;
    public TMP_Text timeText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timeText.text = currentTime.ToString("0"); // to round the value and update text

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("Ending"); // load ending scene when time is up
        }
    }
}