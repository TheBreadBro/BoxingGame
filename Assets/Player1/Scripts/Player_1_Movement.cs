using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float speed = 8f;
    public float jumpHeight = 8f;
    

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isCrouching", GlobalVariables.global.p1isCrouching);
        animator.SetBool("LightAttack", GlobalVariables.global.p1LightAttack);
        animator.SetBool("MediumAttack", GlobalVariables.global.p1MediumAttack);
        animator.SetBool("HeavyAttack", GlobalVariables.global.p1HeavyAttack);
        animator.SetBool("isBlocking", GlobalVariables.global.p1isBlocking);
        if (Input.GetKey(KeyCode.L) && !GlobalVariables.global.p1takenDamage && !GlobalVariables.global.p1isCrouching) //if playermovement input is true and not in hitstun
        {
            GlobalVariables.global.p1isBlocking = true;
        }
        else
        {
            GlobalVariables.global.p1isBlocking = false;
        }
        if (Input.GetKey(KeyCode.RightArrow) && !GlobalVariables.global.p1takenDamage &&!GlobalVariables.global.p1isCrouching && !GlobalVariables.global.p1LightAttack && !GlobalVariables.global.p1MediumAttack && !GlobalVariables.global.p1HeavyAttack && !Input.GetKey(KeyCode.L))
        {
            Debug.Log("Moving Forward");
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            animator.SetBool("WalkingForward", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && !GlobalVariables.global.p1takenDamage && !GlobalVariables.global.p1isCrouching&&!GlobalVariables.global.p1LightAttack&& !GlobalVariables.global.p1MediumAttack && !GlobalVariables.global.p1HeavyAttack && !Input.GetKey(KeyCode.L))
        {
            Debug.Log("Mobing Backwards");
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            animator.SetBool("WalkingForward", true);
        }
        else
        {
            animator.SetBool("WalkingForward", false);
        }
        if (Input.GetKey(KeyCode.DownArrow) && !GlobalVariables.global.p1takenDamage) { 
            Debug.Log("Crouching");
            GlobalVariables.global.p1isCrouching = true;
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.L) && !GlobalVariables.global.p1takenDamage)
            {
                GlobalVariables.global.p1isBlocking = true;
            }
            else
            {
                GlobalVariables.global.p1isBlocking = false;
            }
        }
        else
        {
            GlobalVariables.global.p1isCrouching = false;
        }
    }
}
