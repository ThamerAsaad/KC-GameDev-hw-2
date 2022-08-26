using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    static BackGroundMusic backGroundMusic;
    void Awake()
    {
        if(backGroundMusic == null)
        {
            backGroundMusic = this;
            DontDestroyOnLoad(backGroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
