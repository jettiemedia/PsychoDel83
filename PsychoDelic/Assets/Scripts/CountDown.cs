using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    private Rigidbody rb;
    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object

    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
        DontDestroyOnLoad(gameObject);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        countdown.text = ("" + timeLeft); //Showing the Score on the Canvas

        if (sceneName == "Failure")
        {
            Destroy(gameObject);
        }
        if (sceneName == "Menu")
        {
            Destroy(gameObject);
        }
        if (sceneName == "Ending")
        {
            Destroy(gameObject);
        }
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("Failure", LoadSceneMode.Single);
        }
    }
        IEnumerator LoseTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                timeLeft--;
            }

        }
    }