using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public Rigidbody playerRigidbody; // Reference to the player's Rigidbody component
    public float speed = 10f; // Speed of the player movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal_Speed = Input.GetAxisRaw("Horizontal");
        float Vertical_Speed = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(Horizontal_Speed, 0.0f, Vertical_Speed).normalized * speed;
        //velocity = Vector3.ClampMagnitude(velocity, m_speed);
        playerRigidbody.linearVelocity = velocity;
    }
    
    public void Die()
    {
        // Handle player death logic here
        Debug.Log("Player has died!");
        // You can add more logic, such as respawning or ending the game
    }
}
