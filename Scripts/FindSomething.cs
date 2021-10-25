using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindSomething : MonoBehaviour
{
    private Animator anim;

    public void Action(){
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("FindSomething", true);
    }

    public void Back2Neutral(){
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("FindSomething", false);
    }

}
