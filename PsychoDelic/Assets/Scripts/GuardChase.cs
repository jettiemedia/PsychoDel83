using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardChase : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.tag == "Player")
            //SceneManager.LoadScene("Failure", LoadSceneMode.Single);

    }

    public Transform Player;
    public float Speed;
    int MaxDist = 125;
    int MinDist = 100;




    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * Speed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }
}