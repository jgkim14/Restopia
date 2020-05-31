using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.Animations;

public class blocks : MonoBehaviour
{

    Vector2 FloorVector = new Vector2(0.0f, -25f);

    Vector2 RightVector = new Vector2(25f, 0f);

    Vector2 CellingVector = new Vector2(0.0f, 25f);

    Vector2 LeftVector = new Vector2(-25f, 0f);

    [SerializeField]
    private ConstantForce2D Force2D;

    [SerializeField]
    private Rigidbody2D MyRigid;

    [SerializeField]
    private GameObject character;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "reversal")
        {
            MoveCharacter.Jumpcount = 0;
            if (Force2D.force == FloorVector)
                Force2D.force = CellingVector;

            else if (Force2D.force == CellingVector)
                Force2D.force = FloorVector;

            else if (Force2D.force == LeftVector)
                Force2D.force = RightVector;

            else if (Force2D.force == RightVector)
                Force2D.force = LeftVector;
        }

        if (collision.gameObject.tag == "crash")
        {
            Return();
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        /*if (collision.gameObject.tag == "reversal")
        {
            MyRigid.velocity = new Vector2(0, 0);
            MoveCharacter.Jumpcount = 0;
            if (Force2D.force == FloorVector)
                Force2D.force = CellingVector;

            else if (Force2D.force == CellingVector)
                Force2D.force = FloorVector;

            else if (Force2D.force == LeftVector)
                Force2D.force = RightVector;

            else if (Force2D.force == RightVector)
                Force2D.force = LeftVector;
        }*/
        if (collision.gameObject.tag == "crash")
        {
            Return();
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "outside")
        {
            Return();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "crash")
        {
            Return();
        }
    }



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "crash")
        {
            Return();
        }
    }

     void Return()
    {
        MoveCharacter.a = false;
        MoveCharacter.b = false;
        Force2D.force = Status.FloorVector;
        MyRigid.velocity = new Vector2(0, 0);
        character.transform.position = new Vector2(0, 0);
        character.transform.rotation = Quaternion.Euler(0, 0, 0);
        MoveCharacter.anim.SetBool("stay", true);
        MoveCharacter.anim.SetBool("walk", false);
    }

}
