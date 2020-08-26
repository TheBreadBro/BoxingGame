using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Animator p1animator;
    public Animator p2animator;
    void Update()
    {
        if(GlobalVariables.global.p1Health<=0)
        {
            p1animator.SetBool("isDead", true);
            p1animator.SetBool("DamageTaken", false);
        }
        if(GlobalVariables.global.p2Health<=0)
        {
            p2animator.SetBool("isDead", true);
            p2animator.SetBool("DamageTaken", false);
        }
    }
}
