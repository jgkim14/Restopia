using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage4 : MonoBehaviour
{
    GameObject character;

    void Start()
    {
        Crash.die = true;
        Status.NowStage = 4;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[4];
        SoundManager.instance.audiosource.Play();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag")
        {
            SceneManager.LoadScene("gameclear");
            if(Status.Stage < 4)
                Status.Stage = 4;
            Crash.die = false;
            //Status.save();
        }
    }
}
