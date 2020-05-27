using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Gravitybody : MonoBehaviour
{

    Vector2 FloorVector = new Vector2(0.0f, -25f);

    Vector2 RightVector = new Vector2(25f, 0f);

    Vector2 CellingVector = new Vector2(0.0f, 25f);

    Vector2 LeftVector = new Vector2(-25f, 0f);

    [SerializeField]
    private ConstantForce2D Force2D;

    [SerializeField]
    private Rigidbody2D MyRigid;



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "rightwall")
        {
            MoveCharacter.celling = false;
            //OutherTurn();
        }

        if (collision.gameObject.tag == "celling")
        {
            MoveCharacter.celling = true;
            //Turn();
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "rightwall")
        {
            MoveCharacter.celling = false;
            //OutherTurn();
        }

        if (collision.gameObject.tag == "celling")
        {
            MoveCharacter.celling = true;
            //Turn();
        }
    }


    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "rightwall")
        {
            MoveCharacter.celling = true;
        }

        if (collision.gameObject.tag == "celling")
        {
            MoveCharacter.celling = false;
        }

    }



    void Turn()
    {
        if (!MoveCharacter.celling)
        {
            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.a = true;
                MoveCharacter.b = false;
            }
        }
    }
    void OutherTurn()
    {

        if (MoveCharacter.celling)
        {
            if (MoveCharacter.a)
            {
                MoveCharacter.a = false;
                MoveCharacter.b = true;
            }
            else if (MoveCharacter.b)
            {
                MoveCharacter.a = true;
                MoveCharacter.b = false;
            }
        }
    }*/
}
