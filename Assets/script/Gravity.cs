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



    private void OnCollisionStay2D(Collision2D collision)
    {
            if (MoveCharacter.Jumpcount < Status.Jumpcount)
            {
                if (collision.gameObject.tag == "floor")
                {
                    //Force2D.force = FloorVector;
                    Physics2D.gravity = Status.FloorVector;
                    MyRigid.velocity = new Vector2(0, 1);

                }

                if (collision.gameObject.tag == "rightwall")
                {
                    //Force2D.force = RightVector;
                    Physics2D.gravity = Status.RightVector;
                    MyRigid.velocity = new Vector2(-1, 0);


                }
                if (collision.gameObject.tag == "celling")
                {
                    //Force2D.force = CellingVector;
                    Physics2D.gravity = Status.CellingVector;
                    MyRigid.velocity = new Vector2(0, -1);


                }
                if (collision.gameObject.tag == "leftwall")
                {
                     //Force2D.force = LeftVector;
                    Physics2D.gravity = Status.LeftVector;
                    MyRigid.velocity = new Vector2(1, 0);
                
             }



            if (collision.gameObject.tag == "flag")
            {
                MyRigid.velocity = new Vector2(0, 0);
                Physics2D.gravity = Status.FloorVector;
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (MoveCharacter.Jumpcount < Status.Jumpcount)
        {
            if (collision.gameObject.tag == "floor")
            {
                Physics2D.gravity = Status.FloorVector;

            }

            if (collision.gameObject.tag == "rightwall")
            {
                Physics2D.gravity = Status.RightVector;

            }
            if (collision.gameObject.tag == "celling")
            {
                Physics2D.gravity = Status.CellingVector;

            }
            if (collision.gameObject.tag == "leftwall")
            {
                Physics2D.gravity = Status.LeftVector;

            }
        }


        

        if (collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling")
            MoveCharacter.turnjump = 0;

}




    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "outside")
        {
            Physics2D.gravity = Status.FloorVector;
            MyRigid.velocity = new Vector2(0, 0);

        }
        if (collision.gameObject.tag == "flag")
        {
            MyRigid.velocity = new Vector2(0, 0);
            Physics2D.gravity = Status.FloorVector;
        }
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" )
            MoveCharacter.turnjump = 0;
    }*/


    
}
