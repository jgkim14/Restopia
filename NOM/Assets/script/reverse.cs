using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverse : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rightwall")
        {
            MoveCharacter.celling = false;
            MoveCharacter.floor = false;
            MoveCharacter.rightside = true;
            MoveCharacter.leftside = false;

        }

        if (collision.gameObject.tag == "leftwall")
        {
            MoveCharacter.celling = false;
            MoveCharacter.floor = false;
            MoveCharacter.rightside = false;
            MoveCharacter.leftside = true;

        }
        if (collision.gameObject.tag == "celling")
        {
            MoveCharacter.celling = true;
            MoveCharacter.floor = false;
            MoveCharacter.rightside = false;
            MoveCharacter.leftside = false;
        }
        if (collision.gameObject.tag == "floor")
        {
            MoveCharacter.celling = false;
            MoveCharacter.leftside = false;
            MoveCharacter.rightside = false;
            MoveCharacter.floor = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rightwall")
        {
            MoveCharacter.celling = false;
            MoveCharacter.floor = false;
            MoveCharacter.rightside = true;
            MoveCharacter.leftside = false;

        }

        if (collision.gameObject.tag == "leftwall")
        {
            MoveCharacter.celling = false;
            MoveCharacter.floor = false;
            MoveCharacter.rightside = false;
            MoveCharacter.leftside = true;

        }
        if (collision.gameObject.tag == "celling")
        {
            MoveCharacter.celling = true;
            MoveCharacter.floor = false;
            MoveCharacter.rightside = false;
            MoveCharacter.leftside = false;
        }
        if (collision.gameObject.tag == "floor")
        {
            MoveCharacter.celling = false;
            MoveCharacter.leftside = false;
            MoveCharacter.rightside = false;
            MoveCharacter.floor = true;
        }
    }

    /*if (collision.gameObject.tag == "rightwall")
    {
        if (MoveCharacter.leftside)
        {
            MoveCharacter.leftside = false;
            MoveCharacter.rightside = true;

            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.b = false;
                MoveCharacter.a = true;
            }

        }

    }
    if (collision.gameObject.tag == "leftwall")
    {
        if (MoveCharacter.rightside)
        {
            MoveCharacter.rightside = false;
            MoveCharacter.leftside = true;

            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.b = false;
                MoveCharacter.a = true;
            }

        }

    }



}

private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "leftwall")
    {
        if (MoveCharacter.celling)
        {
            MoveCharacter.celling = false;
            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.b = false;
                MoveCharacter.a = true;
            }
        }
    }
    if (collision.gameObject.tag == "celling")
    {
        if (!MoveCharacter.celling)
        {
            MoveCharacter.celling = true;
            if (!MoveCharacter.floor)
            {
                if (MoveCharacter.a)
                {
                    MoveCharacter.a = false;
                    MoveCharacter.b = true;
                }
                else if (MoveCharacter.b)
                {
                    MoveCharacter.b = false;
                    MoveCharacter.a = true;
                }

            }
        }
    }
    /*if(collision.gameObject.tag == "rightwall")
    {
        if (MoveCharacter.leftside)
        {
            MoveCharacter.leftside = false;
            MoveCharacter.rightside = true;

            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.b = false;
                MoveCharacter.a = true;
            }

        }

    }
    if(collision.gameObject.tag == "leftwall")
    {
        if (MoveCharacter.rightside)
        {
            MoveCharacter.rightside = false;
            MoveCharacter.leftside = true;

            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.b = false;
                MoveCharacter.a = true;
            }

        }

    }*/

}
