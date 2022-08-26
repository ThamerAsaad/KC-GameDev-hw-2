using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounc : MonoBehaviour
{
    public GameObject HitSFX;
    public ball ballMovement;
    public ScoreManager scoreMangar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX = 1; 
        if(collision.gameObject.name == "Player 1")
        {
            positionX = 1;
        }
        else
        {
            positionX = -1;
        }
        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;
        
        ballMovement.increaseHitCounter();

        ballMovement.BallMove(new Vector2(positionX,positionY));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
        }
        else if (collision.gameObject.name == "Right Bordur")
        {
            scoreMangar.Player1Goal();
            ballMovement.Player1Start = false;
            StartCoroutine(ballMovement.Launch());

        }
        else if(collision.gameObject.tag == "Left Bordur")
        {
            scoreMangar.Player2Goal();
            ballMovement.Player1Start = true;
            StartCoroutine(ballMovement.Launch());
        }
        Instantiate(HitSFX, transform.position, transform.rotation);
    }
}
