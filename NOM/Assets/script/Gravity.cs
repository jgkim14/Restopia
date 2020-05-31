using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    Vector2 FloorVector = new Vector2(0.0f, -25f);

    Vector2 RightVector = new Vector2(25f, 0f);

    Vector2 CellingVector = new Vector2(0.0f, 25f);

    Vector2 LeftVector = new Vector2(-25f, 0f);

    [SerializeField]
    private ConstantForce2D Force2D;

    [SerializeField]
    private Rigidbody2D MyRigid;


    public static bool Jumper = false;



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (MoveCharacter.Jumpcount < Status.Jumpcount)
        {
            if (collision.gameObject.tag == "floor")
            {
                Force2D.force = FloorVector;

            }

            if (collision.gameObject.tag == "rightwall")
            {
                Force2D.force = RightVector;
                

            }
            if (collision.gameObject.tag == "celling")
            {
                Force2D.force = CellingVector;
                

            }
            if (collision.gameObject.tag == "leftwall")
            {
                Force2D.force = LeftVector;
                
            }



            if (collision.gameObject.tag == "flag")
            {
                MyRigid.velocity = new Vector2(0, 0);
                Force2D.force = Status.FloorVector;
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (MoveCharacter.Jumpcount < Status.Jumpcount)
        {
            if (collision.gameObject.tag == "floor")
            {
                Force2D.force = FloorVector;

            }

            if (collision.gameObject.tag == "rightwall")
            {
                Force2D.force = RightVector;

            }
            if (collision.gameObject.tag == "celling")
            {
                Force2D.force = CellingVector;

            }
            if (collision.gameObject.tag == "leftwall")
            {
                Force2D.force = LeftVector;

            }


        }

        if (collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling")
            MoveCharacter.turnjump = 0;


      


    }




    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "outside")
        {
            Force2D.force = Status.FloorVector;
            MyRigid.velocity = new Vector2(0, 0);

        }
        if (collision.gameObject.tag == "flag")
        {
            MyRigid.velocity = new Vector2(0, 0);
            Force2D.force = Status.FloorVector;
        }
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" )
            MoveCharacter.turnjump = 0;
    }*/


    
}
