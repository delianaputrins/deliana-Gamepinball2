using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;

    
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animator

            animator.SetTrigger("hit");
        }
    }
}
