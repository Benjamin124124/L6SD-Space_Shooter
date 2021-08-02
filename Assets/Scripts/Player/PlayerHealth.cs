using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Rigidbody2D body;
    public int health = 1;
    public GameObject deathEffect, gameOverText, restartButton;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        gameOverText.SetActive (false);
        restartButton.SetActive (false);
        gameObject.SetActive (true);
    }
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameOver();
        }
        void GameOver()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            gameOverText.SetActive (true);
            restartButton.SetActive (true);
            gameObject.SetActive (false);

        }
    }
}
