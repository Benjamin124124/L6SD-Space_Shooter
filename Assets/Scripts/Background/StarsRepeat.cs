using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsRepeat : MonoBehaviour
{
    private BoxCollider2D m_starsCollider;
    private float m_starsSize;
    // Start is called before the first frame update
    void Start()
    {
        m_starsCollider = GetComponent<BoxCollider2D>();
        m_starsSize = m_starsCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -m_starsSize)
        {
            RepeatStars();
        }
    }
    void RepeatStars()
    {
        Vector2 SToffset = new Vector2(0, m_starsSize * 2f);
        transform.position = (Vector2)transform.position + SToffset;
    }
}
