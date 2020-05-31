using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegUnit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "nogravityline")
        {
            MoveCharacter.Jumpcount = Status.Jumpcount;
        }
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" || collision.gameObject.tag == "leftwall")
        {
            MoveCharacter.Jumping = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" || collision.gameObject.tag == "leftwall")
        {
            MoveCharacter.Jumping = false;
        }
    }


}
