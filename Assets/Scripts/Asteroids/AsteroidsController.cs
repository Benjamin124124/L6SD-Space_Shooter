using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsController : MonoBehaviour
{
    public float lastTouchDamageTime, touchDamageCooldown, touchDamage, touchDamageWidth, touchDamageHeight;
    public Transform touchDamageCheck;
    public LayerMask whatIsPlayer;
    public Vector2 touchDamageBotLeft, touchDamageTopRight;
    public float[] attackDetails = new float[2];
    // Start is called before the first frame update
    void EnterMovingState()
    {
        
    }

    // Update is called once per frame
    void UpdateMovingState()
    {
      CheckTouchDamage();
    }
    public void CheckTouchDamage()
    {
        if(Time.time >= lastTouchDamageTime + touchDamageCooldown)
        {
            touchDamageBotLeft.Set(touchDamageCheck.position.x - (touchDamageWidth / 2), touchDamageCheck.position.y - (touchDamageHeight / 2));
            touchDamageTopRight.Set(touchDamageCheck.position.x + (touchDamageWidth / 2), touchDamageCheck.position.y + (touchDamageHeight / 2));
            Collider2D hit = Physics2D.OverlapArea(touchDamageBotLeft, touchDamageTopRight, whatIsPlayer);
            if (hit != null)
            {
                lastTouchDamageTime = Time.time;
                attackDetails[0] = touchDamage;
                hit.SendMessage("Damage", attackDetails);
            }
        }
    }
}
