using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //character controller variables
    private CharacterController charController;
    public float speed;

    //scene transtion variables
    public string index;
    //public Image black;
    public Animator anim;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //no pause/ending yet "esc" for force quit
        if (Input.GetKey("escape"))
            Application.Quit();

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal, 0, vertical);

        charController.SimpleMove(movement * Time.deltaTime * speed);
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
        else if (other.gameObject.CompareTag("Room 1"))
        {
            //SceneManager.LoadScene("Room 1");
            index = "Room 1";
            Fading(index);
            Debug.Log("Room 1");
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
            Debug.Log("Load level 2");
        }
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

}
