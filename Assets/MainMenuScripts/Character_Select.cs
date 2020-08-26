using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Select : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Kassadin1;
    public GameObject Kassadin2;
    public GameObject player1;
    public GameObject player2;
    public Rigidbody2D Rigid1;
    public Rigidbody2D Rigid2;
    void Update()
    {
        int player1CharacterSelected = 0;
        int player2CharacterSelected = 0;
        if(Input.GetKey(KeyCode.S))
        {
            player1CharacterSelected++;
            if(player1CharacterSelected==24)
            {
                player1CharacterSelected = 0;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            player1CharacterSelected--;
            if (player1CharacterSelected == -1)
            {
                player1CharacterSelected = 23;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player2CharacterSelected++;
            if (player2CharacterSelected == 24)
            {
                player2CharacterSelected = 0;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player1CharacterSelected++;
            if (player1CharacterSelected == -1)
            {
                player1CharacterSelected = 23;
            }
        }
        if (player1CharacterSelected==0&& Input.GetKey(KeyCode.LeftBracket)) //if playermovement input is true and not in hitstun
        {
            player1.SetActive(true);
            Kassadin1.SetActive(true);
            Rigid1.gravityScale = 4;
        }
        if(player2CharacterSelected==0&& Input.GetKey(KeyCode.RightBracket))
        {
            player2.SetActive(true);
            Kassadin2.SetActive(true);
            Rigid2.gravityScale = 4;
        }
    }
}
