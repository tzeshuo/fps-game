using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingController : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public float shootRate;
    public float shootForce;
    public InputAction attack;

    void Start()
    {
        attack = InputSystem.actions.FindAction("Attack");
    }

    void Update()
    {
        if (attack.WasPressedThisFrame())
        {
            GameObject spawnedBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody rb = spawnedBullet.GetComponent<Rigidbody>();
            rb.AddForce(bulletSpawnPoint.forward * shootForce);
        }
    }
}