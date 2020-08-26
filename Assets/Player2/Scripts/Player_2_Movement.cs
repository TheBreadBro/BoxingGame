using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float speed = 8f;
    public float jumpHeight = 8f;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isCrouching", GlobalVariables.global.p2isCrouching);
        animator.SetBool("LightAttack", GlobalVariables.global.p2LightAttack);
        animator.SetBool("MediumAttack", GlobalVariables.global.p2MediumAttack);
        animator.SetBool("HeavyAttack", GlobalVariables.global.p2HeavyAttack);
        animator.SetBool("isBlocking", GlobalVariables.global.p2isBlocking);
        if (Input.GetKey(KeyCode.Y) && !GlobalVariables.global.p2takenDamage && !GlobalVariables.global.p2isCrouching) //if playermovement input is true and not in hitstun
        {
            GlobalVariables.global.p2isBlocking = true;
        }
        else
        {
            GlobalVariables.global.p2isBlocking = false;
        }
        if (Input.GetKey(KeyCode.D) && !GlobalVariables.global.p2takenDamage && !GlobalVariables.global.p2isCrouching && !GlobalVariables.global.p2LightAttack && !GlobalVariables.global.p2MediumAttack && !GlobalVariables.global.p2HeavyAttack && !Input.GetKey(KeyCode.Y))
        {
            Debug.Log("Moving Forward");
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            animator.SetBool("WalkingForward", true);
        }
        else if (Input.GetKey(KeyCode.A) && !GlobalVariables.global.p2takenDamage && !GlobalVariables.global.p2isCrouching && !GlobalVariables.global.p2LightAttack && !GlobalVariables.global.p2MediumAttack && !GlobalVariables.global.p2HeavyAttack && !Input.GetKey(KeyCode.Y))
        {
            Debug.Log("Mobing Backwards");
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
            animator.SetBool("WalkingForward", true);
        }
        else
        {
            animator.SetBool("WalkingForward", false);
        }
        if (Input.GetKey(KeyCode.S) && !GlobalVariables.global.p2takenDamage)
        {
            Debug.Log("Crouching");
            GlobalVariables.global.p2isCrouching = true;
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Y) && !GlobalVariables.global.p2takenDamage)
            {
                GlobalVariables.global.p2isBlocking = true;
            }
            else
            {
                GlobalVariables.global.p2isBlocking = false;
            }
        }
        else
        {
            GlobalVariables.global.p2isCrouching = false;
        }
    }
}
