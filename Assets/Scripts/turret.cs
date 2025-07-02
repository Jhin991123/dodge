using UnityEngine;

public class turret : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public Transform firePoint; // The point from which the bullet will be fired
    public float fireRate = 1f; // Rate of fire in bullets per second
    private float nextFireTime = 0f; // Time when the turret can fire next
                                     // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float MinDelay = 0.5f;
    private float MaxDelay = 1.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
        Fire();
    
    }
    public void Fire()
    {
        nextFireTime = Random.Range(MinDelay, MaxDelay);
        fireRate += Time.deltaTime;
        if (fireRate >= nextFireTime)
        {
            // Instantiate a bullet at the fire point's position and rotation
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            // Set the next fire time based on the fire rate

            fireRate = 0f; // Reset fire rate for the next shot
            // Optionally, you can add logic to destroy the bullet after a certain time
        }
    }
}
