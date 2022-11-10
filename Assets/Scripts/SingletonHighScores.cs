using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;


public class SingletonHighScores : MonoBehaviour
{

    public static SingletonHighScores Instance;
    
    private void Awake()
    {
        //This is the code that makes this a singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    public void StartGame()
    {
        //Makes start button load scene
        SceneManager.LoadScene(0);
    }
}
