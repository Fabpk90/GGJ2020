using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RightSide : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Shoot", false);
        if (Gamepad.current.rightTrigger.isPressed) { animator.SetBool("Shoot", true); }
    }
}
