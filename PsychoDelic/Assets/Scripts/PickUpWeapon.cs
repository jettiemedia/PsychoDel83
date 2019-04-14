using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeapon : MonoBehaviour
{
    //private Text pickUpText;

    private bool inRange;

    private void Start()
    {
       // pickUpText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
          //  pickUpText.gameObject.SetActive(true);
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
           //    pickUpText.gameObject.SetActive(false);
            inRange = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
        //set inventory gun to true
    }


}
