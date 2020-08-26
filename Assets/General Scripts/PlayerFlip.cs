using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    public Transform p1Transform;
    public Transform p2Transform;
    public bool correct = true;

    // Update is called once per frame
    void Update()
    {
        float p1pos = p1Transform.position.x;
        float p2pos = p2Transform.position.x;
        if (p1Transform.position.x < p2Transform.position.x)
        {
            p1Transform.localScale = new Vector3(10, 10, 0);
            p2Transform.localScale = new Vector3(-10, 10, 0);
            correct = true;
        }
        else
        {
            p1Transform.localScale = new Vector3(-10, 10, 0);
            p2Transform.localScale = new Vector3(10, 10, 0);
            correct = false;
        }
    }
}
 