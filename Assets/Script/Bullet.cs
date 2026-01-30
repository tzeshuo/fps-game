using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    private void Awake()
    {
        // This timer handles bullets that hit the ground or fly into the sky.
        // It will delete the bullet after 3 seconds regardless.
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if we hit something that is NOT the terrain
        if (collision.gameObject.name != "Terrain")
        {
            // 1. Destroy the target (Tank/Drum)
            Destroy(collision.gameObject);

            // 2. Destroy the bullet immediately because it hit a target
            Destroy(gameObject);
        }

        // If it WAS the terrain, we do nothing here.
        // The bullet will just sit there until the 'life' timer from Awake() runs out.
    }
}