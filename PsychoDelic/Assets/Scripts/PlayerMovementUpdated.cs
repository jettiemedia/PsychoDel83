using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovementUpdated : MonoBehaviour
{
    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object
    private Interactable focus;
    private CharacterController charController;
    public string index;
    public float speed = 4.0F;
    public float jumpSpeed = 6.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;
    public Animator anim;

    Camera cam;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {

        
        //no pause/ending yet "esc" for force quit
        if (Input.GetKey("escape"))
            Application.Quit();

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //Rotate Player
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

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

        /*else if (other.gameObjest.CompareTag("namethisandtagthedownstairsdoor") && winState = true){
            index = "nameofwinscreen";
            Fading(index);
            Debug.Log("Win");
        }
        else if (other.gameObjest.CompareTag("namethisandtagthedownstairsdoor") && winState = false)
        {
            index = "nameofwinscreen";
            Fading(index);
            Debug.Log("Win");
        }*/

        if (other.tag == "Choc")
        {
            other.gameObject.SetActive(false);
            timeLeft = timeLeft = 10;
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

    void SetFocus(Interactable newFocus)
    {
        focus = newFocus;
    }

    void RemoveFocus()
    {
        focus = null;
    }

}

