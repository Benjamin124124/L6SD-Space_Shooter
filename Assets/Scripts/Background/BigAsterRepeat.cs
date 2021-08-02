using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAsterRepeat : MonoBehaviour
{
    private BoxCollider2D m_BigAsterCollider;
    private float m_BigAsterSize;
    // Start is called before the first frame update
    void Start()
    {
        m_BigAsterCollider = GetComponent<BoxCollider2D>();
        m_BigAsterSize = m_BigAsterCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -m_BigAsterSize)
        {
            RepeatStars();
        }
    }
    void RepeatStars()
    {
        Vector2 SToffset = new Vector2(0, m_BigAsterSize * 2f);
        transform.position = (Vector2)transform.position + SToffset;
    }
}
