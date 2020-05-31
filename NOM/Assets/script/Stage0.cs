using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage0 : MonoBehaviour
{
    public GameObject Unit;

    public GameObject Coin;

    float x, y;

    public float setunittime = 20;
    public float setcointime = 10;

    public float Unittime;

    public float Cointime;


    GameObject character;

    void Start()
    {
        Crash.die = true;
        Status.NowStage = 0;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[0];
        SoundManager.instance.audiosource.Play();
    }



    void Update()
    {
        if (Crash.die)
        {
            Unittime += Time.deltaTime;
            Cointime += Time.deltaTime;
            if (Unittime > setunittime)
            {
                Monsters();
                Unittime -= setunittime;
            }
            if (Cointime > setcointime)
            {
                Coins();
                Cointime -= setcointime;
            }
        }



        else
        {
            Cointime = 0;
            Unittime = 0;
        }
    }
    void Monsters()
    {
        x = Random.Range(0f, 15f);
        y = Random.Range(7.5f, 22.5f);

        Instantiate(Unit, new Vector2(x, y), Quaternion.identity);
    }


    void Coins()
    {
        x = Random.Range(0f, 15f);
        y = Random.Range(7.5f, 22.5f);

        Instantiate(Coin, new Vector2(x, y), Quaternion.identity);
    }
}
