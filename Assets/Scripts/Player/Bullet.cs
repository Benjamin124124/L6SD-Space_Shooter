using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D (Collider2D hitInfo)
    {
        AsteroidHealth Enemy = hitInfo.GetComponent<AsteroidHealth>();
        if (Enemy != null)
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        enabled = false;
        Destroy(gameObject);
    }
}
