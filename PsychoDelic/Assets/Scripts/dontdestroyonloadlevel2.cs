using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontdestroyonloadlevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Level 3")
        {
            Destroy(gameObject);
        }
        else if (sceneName == "Victory")
        {
            Destroy(gameObject);
        }
        else if (sceneName == "Failure")
        {
            Destroy(gameObject);
        }
        else if (sceneName == "Menu")
        {
            Destroy(gameObject);
        }
    }
}