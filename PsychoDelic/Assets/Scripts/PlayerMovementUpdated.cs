﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovementUpdated : MonoBehaviour
{

    public Interactable focus;
    private CharacterController charController;
    public string index;
    float speed = 100;
    
    public Animator anim;
    int runStateHash = Animator.StringToHash("Base Layer.Run");

    Camera cam;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    void Start()
    {
        cam = Camera.main;
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        float move = Input.GetAxis("Vertical");
        anim.SetFloat("speed", move);
        
        //no pause/ending yet "esc" for force quit
        if (Input.GetKey("escape"))
            Application.Quit();

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        //Debug.Log("Hor: " + horizontal);

        var movement = new Vector3(horizontal, 0, vertical);

        charController.SimpleMove(movement * Time.deltaTime * speed);

        //temp pause
        //removed

        //interact with objects
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hallway"))
        {
            //SceneManager.LoadScene("Upstairs");
            index = "Upstairs";
            Fading(index);
            Debug.Log("Main Hall");
        }
        else if (other.gameObject.CompareTag("Room 5"))
        {
            //SceneManager.LoadScene("Room 1.1");
            index = "Room 5";
            Fading(index);
            Debug.Log("Room 5");
        }
        else if (other.gameObject.CompareTag("Room 2"))
        {
            //SceneManager.LoadScene("Room 2");
            index = "Room 2";
            Fading(index);
            Debug.Log("Room 2");
        }
        else if (other.gameObject.CompareTag("Room 3"))
        {
            //SceneManager.LoadScene("Room 3");
            index = "Room 3";
            Fading(index);
            Debug.Log("Room 3");
        }
        else if (other.gameObject.CompareTag("Room 4"))
        {
            //SceneManager.LoadScene("Room 4");
            index = "Room 4";
            Fading(index);
            Debug.Log("Room 4");
        }
        else if (other.gameObject.CompareTag("Stairs"))
        {
            //SceneManager.LoadScene("Downstairs");
            index = "Downstairs";
            Fading(index);
            Debug.Log("Lobby");
        }
        else if (other.gameObject.CompareTag("Level 2"))
        {
            //SceneManager.LoadScene("Level 2");
            index = "Level 2";
            Fading(index);
            Debug.Log("Level 2");
        }

        else if (other.gameObject.CompareTag("Level 3"))
        {
            //SceneManager.LoadScene("Level 3");
            index = "Level 3";
            Fading(index);
            Debug.Log("Level 3");
        }

        //else if (other.gameObjest.CompareTag("namethisandtagthedownstairsdoor") && winState = true){
            //index = "nameofwinscreen";
            //Fading(index);
            //Debug.Log("Win");
        //}
        //else if (other.gameObjest.CompareTag("namethisandtagthedownstairsdoor") && winState = false)
        //{
            //index = "nameofwinscreen";
            //Fading(index);
            //Debug.Log("Win");
        //}
        else
        {
            Debug.Log("This ain't it chief");
        }
    }

    private void Fading(string index)
    {
        anim.SetTrigger("FadeOut");
        //yield return new WaitUntil(() => black.color.a == 1);
        Debug.Log("Load Scene");
        SceneManager.LoadScene(index);

    }

    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }

    void RemoveFocus()
    {
        focus = null;
    }

}

