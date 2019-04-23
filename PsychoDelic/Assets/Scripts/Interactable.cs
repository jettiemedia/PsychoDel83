using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    //radius of interactable objects
    public float radius = 2f;

    bool isFocus = false;
    bool hasInteracted = false;

    public virtual void Interact()
    {
        //can be overwritten
        Debug.Log("Interacting with" + transform.name);
    }

    void Update()
    {
        if (isFocus && !hasInteracted)
        {
            Interact();
            hasInteracted = true;
        }
    }

    //visualize radius
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
