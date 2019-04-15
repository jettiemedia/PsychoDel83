using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOnInput : MonoBehaviour{

    //public EventSystem eventsystem;
    public GameObject selectedObject;

    private bool buttonSelected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (SelectOnInput.GetAxisRaw("Vertical") != 0 && buttonSelected== false)
        //{
         //   eventSystem.SetSelectedGameObject(selectedObject);
          //  buttonSelected = true;
        //}
        
    }

    private void OnDisable()
    {
        buttonSelected = false;
    }
}
