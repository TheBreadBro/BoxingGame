using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static GlobalVariables global;
    public bool p1LightAttack = false;
    public bool p1MediumAttack = false;
    public bool p1HeavyAttack = false;
    public bool p2LightAttack = false;
    public bool p2MediumAttack = false;
    public bool p2HeavyAttack = false;
    public bool p1isCrouching = false;
    public bool p2isCrouching = false;
    public int p1Health = 200;
    public int p2Health = 200;
    public int p1MaxHealth = 200;
    public int p2MaxHealth = 200;
    public bool p1takenDamage = false;
    public bool p2takenDamage = false;
    public bool p1isBlocking = false;
    public bool p2isBlocking = false;
    public Rigidbody2D p1;
    public Rigidbody2D p2;
    // Start is called before the first frame update
    void Start()
    {
        global = this;
    }
}
