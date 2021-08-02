using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAsteroidsScroll : MonoBehaviour
{
    private Rigidbody2D RigidBody;
    private float m_Speed = -1.5f;
    [SerializeField] private bool m_stopScrolling;
    // Start is called before the first frame update
    void Start()
    {
        RigidBody = GetComponent<Rigidbody2D>();
        RigidBody.velocity = new Vector2(0, m_Speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(m_stopScrolling)
        {
            RigidBody.velocity = Vector2.zero;
        }
        else
        {
            RigidBody.velocity = new Vector2(0, m_Speed);
        }
    }
}
