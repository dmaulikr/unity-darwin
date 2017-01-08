using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    PlayerMovement playerMovement;
    bool isDead;
    bool damaged;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        currentHealth = startingHealth;

        // Setting up the references.
        playerMovement = GetComponent<PlayerMovement>();

        // Set the initial health of the player.
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (damaged)
        {
            Debug.Log("Damage");
        }
        damaged = false;

    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        Debug.Log("Player took damage");

        currentHealth -= amount;

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        playerMovement.enabled = false;
        Debug.Log("Player is dead");
    }
}
