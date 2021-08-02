using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsScrolling : MonoBehaviour
{
    private Rigidbody2D rb;
    private float m_Speed = -4.5f;
    [SerializeField] private bool m_stopScrolling;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, m_Speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(m_stopScrolling)
        {
            rb.velocity = Vector2.zero;
        }
        else
        {
            rb.velocity = new Vector2(0, m_Speed);
        }
    }
}
