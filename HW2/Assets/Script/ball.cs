using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float StartSpeed;
    public float ExtraSpeed;
    public float MaxExtraSpeed;
    int hitCounter = 0;

    public bool Player1Start = true;

    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    public IEnumerator Launch()
    {
        RestartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);
        if (Player1Start == true)
        {
            BallMove(new Vector2(-1, 0));
        }
        else
        {
            BallMove(new Vector2(1, 0));
        }


    }

    public void BallMove(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = StartSpeed + hitCounter * ExtraSpeed;

        rb.velocity = direction * ballSpeed;
    }

    public void increaseHitCounter()
    {
        if(hitCounter * ExtraSpeed < MaxExtraSpeed)
        {
            hitCounter++;
        }
    }
    public void RestartBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);

    }
}
