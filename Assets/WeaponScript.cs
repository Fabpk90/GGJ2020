using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponScript : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.current.rightTrigger.isPressed) { animator.SetBool("Load", true); }
        if (!Gamepad.current.rightTrigger.isPressed) { animator.SetBool("Load", false); }
    }
}
