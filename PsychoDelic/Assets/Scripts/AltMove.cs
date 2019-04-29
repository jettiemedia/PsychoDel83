using UnityEngine;
using System.Collections;

public class AltMove : MonoBehaviour
{
    public Animator anim;
    public float MaxSpeed = 10;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        Move(x,y);

    }
    private void Move(float x, float y)
    {
        anim.SetFloat("speed", y);
        transform.position += (Vector3.forward * MaxSpeed) * y * Time.deltaTime;


    }

}
