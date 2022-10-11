using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Animator))]
public class ExplosionAnimation : MonoBehaviour
{
    private Animator myAnim;
    public void Setup()
    { 
        myAnim = GetComponent<Animator>();
        myAnim.SetTrigger("Explosion");

    }


}
