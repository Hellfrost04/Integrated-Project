using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM backgroundMusic;

    void Awake()
    {
        //Checks for background music
        if (backgroundMusic == null)
        {
            //Adds background music if it isn't already there
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
