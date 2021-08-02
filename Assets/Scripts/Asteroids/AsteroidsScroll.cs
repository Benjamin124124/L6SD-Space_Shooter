using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsScroll : MonoBehaviour
{
    private Rigidbody2D RigidBody;
    private float m_Speed = -2.5f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        RigidBody = this.GetComponent<Rigidbody2D>();
        RigidBody.velocity = new Vector2(0, m_Speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -screenBounds.y)
        {
            Destroy(this.gameObject);
        }
    }
}
