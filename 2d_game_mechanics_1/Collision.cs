using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int health = 100; // Starting health

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the "Enemy" tag
        if (collision.gameObject.tag == "Enemy")
        {
            // Reduce health by 10 (or any value you prefer)
            health -= 10;

            // Debug message to show the health
            Debug.Log("Health: " + health);

            // If health is 0 or below, handle player death
            if (health <= 0)
            {
                Debug.Log("Game Over!");
                // Add logic for what happens when health reaches 0 (e.g., restart level)
            }
        }
    }
}
