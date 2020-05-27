using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Crashunit : MonoBehaviour
{

    public GameObject character;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "crash")
        {
            Crash.UnitCrash();
            Destroy(character);
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "crash")
        {
            Crash.UnitCrash();
            Destroy(character);
            Debug.Log("실행");
        }
    }


}
