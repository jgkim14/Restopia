using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class stopcoin : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "character")
        {
            Destroy(gameObject);
            MoveCharacter.Money += 100;
        }
    }
}
