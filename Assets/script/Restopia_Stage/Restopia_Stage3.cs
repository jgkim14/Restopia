using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restopia_Stage3 : MonoBehaviour
{


    private void Awake()
    {
        Physics2D.gravity = Status.LeftVector;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "flag")
        {
            SceneManager.LoadScene("gameclear");
        }
    }

}
