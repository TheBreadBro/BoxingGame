using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Attack : MonoBehaviour
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
        GlobalVariables.global.p2Health = GlobalVariables.global.p2MaxHealth;
        p2healthBar.setMaxHealth(GlobalVariables.global.p2MaxHealth);
    }
    private void FixedUpdate()
    {
        if (attackTimer != 0)
        {
            attackTimer--;
        }
        if (hitstunTimer == 0)
        {
            GlobalVariables.global.p1takenDamage = false;
            animator.SetBool("DamageTaken", false);
        }
        else
        {
            GlobalVariables.global.p1takenDamage = true;
            animator.SetBool("DamageTaken", true);
            hitstunTimer--;
        }
        if (!GlobalVariables.global.p2isCrouching && Input.GetKey(KeyCode.G) && attackTimer == 0)
        {
            GlobalVariables.global.p2LightAttack = true;
            GlobalVariables.global.p1takenDamage = false;
            usedAttack = "standingLight";
            attackTimer = 37;
            Debug.Log(usedAttack);
        }
        else if (!GlobalVariables.global.p2isCrouching && Input.GetKey(KeyCode.H) && !GlobalVariables.global.p2LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p2MediumAttack = true;
            GlobalVariables.global.p1takenDamage = false;
            usedAttack = "standingMedium";
            attackTimer = 33;
            Debug.Log(usedAttack);
        }
        else if (!GlobalVariables.global.p2isCrouching && Input.GetKey(KeyCode.J) && !GlobalVariables.global.p2LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p2HeavyAttack = true;
            GlobalVariables.global.p1takenDamage = false;
            usedAttack = "standingHeavy";
            attackTimer = 36;
            Debug.Log(usedAttack);
        }
        else if (GlobalVariables.global.p2isCrouching && Input.GetKey(KeyCode.G) && !GlobalVariables.global.p2LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p2LightAttack = true;
            GlobalVariables.global.p1takenDamage = false;
            usedAttack = "crouchingLight";
            attackTimer = 41;
            Debug.Log(usedAttack);
        }
        else if (GlobalVariables.global.p2isCrouching && Input.GetKey(KeyCode.H) && !GlobalVariables.global.p2LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p2MediumAttack = true;
            GlobalVariables.global.p1takenDamage = false;
            usedAttack = "crouchingMedium";
            attackTimer = 53;
            Debug.Log(usedAttack);
        }
        else if (GlobalVariables.global.p2isCrouching && Input.GetKey(KeyCode.J) && !GlobalVariables.global.p2LightAttack && attackTimer == 0)
        {
            GlobalVariables.global.p2HeavyAttack = true;
            GlobalVariables.global.p1takenDamage = false;
            usedAttack = "crouchingHeavy";
            attackTimer = 24;
            Debug.Log(usedAttack);
        }
        else if (attackTimer == 0)
        {
            GlobalVariables.global.p2LightAttack = false;
            GlobalVariables.global.p2MediumAttack = false;
            GlobalVariables.global.p2HeavyAttack = false;
        }
        if (hitbox.IsTouching(hurtbox) && !GlobalVariables.global.p1takenDamage)
        {
            hitstunTimer = 20;
            if (usedAttack.Equals("standingLight"))
            {
                if (GlobalVariables.global.p1isBlocking)
                {
                    GlobalVariables.global.p1Health -= 2;
                }
                else
                {

                    GlobalVariables.global.p1Health -= 5;
                }
            }
            if (usedAttack.Equals("standingMedium"))
            {
                if (GlobalVariables.global.p1isBlocking)
                {
                    GlobalVariables.global.p1Health -= 4;
                }
                else
                {

                    GlobalVariables.global.p1Health -= 10;
                }
            }
            if (usedAttack.Equals("standingHeavy"))
            {
                if (GlobalVariables.global.p1isBlocking)
                {
                    GlobalVariables.global.p1Health -= 8;
                }
                else
                {

                    GlobalVariables.global.p1Health -= 20;
                }
            }
            if (usedAttack.Equals("crouchingLight"))
            {
                if (GlobalVariables.global.p1isBlocking)
                {
                    GlobalVariables.global.p1Health -= 1;
                }
                else
                {

                    GlobalVariables.global.p1Health -= 3;

                }
            }
            if (usedAttack.Equals("crouchingMedium"))
            {
                if (GlobalVariables.global.p1isBlocking)
                {
                    GlobalVariables.global.p1Health -= 2;
                }
                else
                {

                    GlobalVariables.global.p1Health -= 6;
                }
            }
            if (usedAttack.Equals("crouchingHeavy"))
            {
                if (GlobalVariables.global.p1isBlocking)
                {
                    GlobalVariables.global.p1Health -= 4;
                }
                else
                {
                    GlobalVariables.global.p1Health -= 12;
                }
            }
            p1healthBar.setHealth(GlobalVariables.global.p1Health);
        }
    }
}

