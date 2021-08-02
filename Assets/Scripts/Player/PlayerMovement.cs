using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float dodgeSpeed = 8.0f;
    public GameObject gameOverText, restartButton;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        gameOverText.SetActive (false);
        restartButton.SetActive (false);
        gameObject.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * dodgeSpeed, vertical * dodgeSpeed);
    }
    void OnTriggerEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            GameOver();
        }
        
    }
    void GameOver()
        {
            gameOverText.SetActive (true);
            restartButton.SetActive (true);
            gameObject.SetActive (false);

        }
}
