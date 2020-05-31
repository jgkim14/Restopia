using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour //캐릭터가 벽에 끼었을경우 탈출시킴
{

    [SerializeField]
    private Transform Player;

    bool Cooltime= false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Cooltime)
        {
            if (collision.gameObject.tag == "nogravityline" || collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "floor" || collision.gameObject.tag == "celling")
            {
                if (Physics2D.gravity == Status.FloorVector) 
                { Player.position += new Vector3(0, 0.5f, 0); }

                else if (Physics2D.gravity == Status.RightVector) 
                { Player.position += new Vector3(-0.5f, 0, 0); }

                else if (Physics2D.gravity == Status.LeftVector) 
                { Player.position += new Vector3(0.5f, 0, 0); }

                else if (Physics2D.gravity == Status.CellingVector) 
                { Player.position += new Vector3(0, -0.5f, 0); }

                Cooltime = true;
                StartCoroutine(DetectionCooltime());
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!Cooltime)
        {
            if (collision.gameObject.tag == "nogravityline" || collision.gameObject.tag == "leftwall" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "floor" || collision.gameObject.tag == "celling")
            {
                if (Physics2D.gravity == Status.FloorVector) 
                { Player.position += new Vector3(0, 0.5f, 0); }

                else if (Physics2D.gravity == Status.RightVector) 
                { Player.position += new Vector3(-0.5f, 0, 0); }

                else if (Physics2D.gravity == Status.LeftVector)
                { Player.position += new Vector3(0.5f, 0, 0); }

                else if (Physics2D.gravity == Status.CellingVector)
                { Player.position += new Vector3(0, -0.5f, 0); }

                Cooltime = true;
                StartCoroutine(DetectionCooltime());
            }
        }
    }
    IEnumerator DetectionCooltime()
    {
        yield return new WaitForSeconds(0.5f);
        Cooltime = false;
    }
}
