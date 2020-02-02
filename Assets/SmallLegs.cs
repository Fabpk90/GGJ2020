using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallLegs : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Walking", true);
        }
        if (!Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Walking", false);
        }
    }
}
