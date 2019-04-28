using UnityEngine;
using System.Collections;

public class AltMove : MonoBehaviour
{
    public Animator anim;
    int Speed = 300;
    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash("Move Animator Controller");


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
        {
            anim.SetTrigger(jumpHash);
        }
    }
}
