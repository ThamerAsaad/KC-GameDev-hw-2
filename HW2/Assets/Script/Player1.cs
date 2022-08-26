using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float RacketSpeed;
    Rigidbody2D rb;
    Vector2 RacketDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Horizontal2");
        RacketDirection = new Vector2(0, directionY).normalized; 
    }
    private void FixedUpdate()
    {
        rb.velocity = RacketDirection * RacketSpeed;
    }

}
