using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mneu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
