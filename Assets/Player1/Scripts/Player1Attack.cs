    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Attack : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public Animator animator;
    public int Damage = 0;
    public BoxCollider2D hurtbox;
    public BoxCollider2D hitbox;
    public string usedAttack;
    public int attackTimer = 0;
    public int hitstunTimer = 0;
    public HealthBar p1healthBar;
    public HealthBar p2healthBar;

    void Start()
    {
        GlobalVariables.global.p1Health = GlobalVariables.global.p1MaxHealth;
        p1healthBar.setMaxHealth(GlobalVariables.global.p1MaxHealth);
    }
    private void FixedUpdate()
    {
        if(attackTimer!=0)
        {
            attackTimer--;
        }
        if (hitstunTimer == 0)
        {
            GlobalVariables.global.p2takenDamage = false;
            animator.SetBool("DamageTaken", false);
        }
        else
        {
            GlobalVariables.global.p2takenDamage = true;
            animator.SetBool("DamageTaken", true);
            hitstunTimer--;
        }
        if (!GlobalVariables.global.p1isCrouching && Input.GetKey(KeyCode.Comma) && attackTimer == 0)
        {
            GlobalVariables.global.p1LightAttack = true;
            GlobalVariables.global.p2takenDamage = false;
            usedAttack = "standingLight";
            attackTimer = 37;
            Debug.Log(usedAttack);
        }
        else if (!GlobalVariables.global.p1isCrouching && Input.GetKey(KeyCode.Period) && !GlobalVariables.global.p1LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p1MediumAttack = true;
            GlobalVariables.global.p2takenDamage = false;
            usedAttack = "standingMedium";
            attackTimer = 33;
            Debug.Log(usedAttack);
        }
        else if (!GlobalVariables.global.p1isCrouching && Input.GetKey(KeyCode.Slash)&& !GlobalVariables.global.p1LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p1HeavyAttack = true;
            GlobalVariables.global.p2takenDamage = false;
            usedAttack = "standingHeavy";
            attackTimer = 36;
            Debug.Log(usedAttack);
        }
        else if (GlobalVariables.global.p1isCrouching && Input.GetKey(KeyCode.Comma)&& !GlobalVariables.global.p1LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p1LightAttack = true;
            GlobalVariables.global.p2takenDamage = false;
            usedAttack = "crouchingLight";
            attackTimer = 41;
            Debug.Log(usedAttack);
        }
        else if (GlobalVariables.global.p1isCrouching && Input.GetKey(KeyCode.Period)&& !GlobalVariables.global.p1LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p1MediumAttack = true;
            GlobalVariables.global.p2takenDamage = false;
            usedAttack = "crouchingMedium";
            attackTimer = 53;
            Debug.Log(usedAttack);
        }
        else if (GlobalVariables.global.p1isCrouching && Input.GetKey(KeyCode.Slash)&& !GlobalVariables.global.p1LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p1HeavyAttack = true;
            GlobalVariables.global.p2takenDamage = false;
            usedAttack = "crouchingHeavy";
            attackTimer = 24;
            Debug.Log(usedAttack);
        }
        else if(attackTimer==0)
        {
            GlobalVariables.global.p1LightAttack = false;
            GlobalVariables.global.p1MediumAttack = false;
            GlobalVariables.global.p1HeavyAttack = false;
        }
        if (hitbox.IsTouching(hurtbox) && !GlobalVariables.global.p2takenDamage)
        {
            hitstunTimer = 20;
            if (usedAttack.Equals("standingLight"))
            {
                if(GlobalVariables.global.p2isBlocking)
                {
                    GlobalVariables.global.p2Health -= 2;
                }
                else
                {

                    GlobalVariables.global.p2Health -= 5;
                }
            }
            if (usedAttack.Equals("standingMedium"))
            {
                if (GlobalVariables.global.p2isBlocking)
                {
                    GlobalVariables.global.p2Health -= 4;
                }
                else
                {

                    GlobalVariables.global.p2Health -= 10;
                }
            }
            if (usedAttack.Equals("standingHeavy"))
            {
                if (GlobalVariables.global.p2isBlocking)
                {
                    GlobalVariables.global.p2Health -= 8;
                }
                else
                {

                    GlobalVariables.global.p2Health -= 20;
                }
            }
            if (usedAttack.Equals("crouchingLight"))
            {
                if(GlobalVariables.global.p2isBlocking)
                {
                    GlobalVariables.global.p2Health -= 1;
                }
                else
                {

                    GlobalVariables.global.p2Health -= 3;

                }
            }
            if (usedAttack.Equals("crouchingMedium"))
            {
                if (GlobalVariables.global.p2isBlocking)
                {
                    GlobalVariables.global.p2Health -= 2;
                }
                else
                {

                    GlobalVariables.global.p2Health -= 6;
                }
            }
            if (usedAttack.Equals("crouchingHeavy"))
            {
                if (GlobalVariables.global.p2isBlocking)
                {
                    GlobalVariables.global.p2Health -= 4;
                }
                else
                {
                    GlobalVariables.global.p2Health -= 12;
                }
            }
            p2healthBar.setHealth(GlobalVariables.global.p2Health);
        }
        }
    }

