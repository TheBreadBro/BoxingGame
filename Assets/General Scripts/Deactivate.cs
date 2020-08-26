using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public GameObject deactivatee;
    // Start is called before the first frame update
    void Start()
    {
        deactivatee.SetActive(false);
    }
}
    