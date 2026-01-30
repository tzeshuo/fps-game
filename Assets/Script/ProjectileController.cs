using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public int lastTime = 7;
    public int pointsPerHit = 10; // All items give same score
    public AudioSource audioSource;

    private GameObject scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager");

        // Destroy the bullet after a set time regardless of what it hits
        Destroy(gameObject, lastTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object hit has the "Target" tag
        if (collision.gameObject.CompareTag("Target"))
        {
            // 1. Play sound
            if (audioSource != null)
            {
                audioSource.Play();
            }

            // 2. Add score
            if (scoreManager != null)
            {
                scoreManager.GetComponent<ScoreManager>().Score(pointsPerHit);
            }

            // 3. Destroy target
            Destroy(collision.gameObject);

        }

    }
}