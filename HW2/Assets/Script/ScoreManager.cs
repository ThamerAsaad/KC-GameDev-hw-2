using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{   
    int Player1Score = 0;
    int player2Score = 0;
    public int ScoreToReach;

    public Text Player1ScoreText;
    public Text Player2ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Player1Goal()
    {
        Player1Score++;
        Player1ScoreText.text = Player1Score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        player2Score++;
        Player2ScoreText.text = player2Score.ToString();
        CheckScore();
    }
    void CheckScore()
    {
        if (Player1Score == ScoreToReach || player2Score == ScoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }

}
