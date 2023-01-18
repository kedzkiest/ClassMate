using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;
    private static readonly int Default = Animator.StringToHash("Default");
    private static readonly int FindSomething = Animator.StringToHash("FindSomething");
    private static readonly int Walking = Animator.StringToHash("Walking");

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Action_FindSomething()
    {
        anim.SetTrigger(FindSomething);
    }

    public void Action_Walking()
    {
        anim.SetTrigger(Walking);
    }

    public void Action_Neutral(){
        anim.ResetTrigger(FindSomething);
        anim.ResetTrigger(Walking);
        anim.SetTrigger(Default);
    }

}
