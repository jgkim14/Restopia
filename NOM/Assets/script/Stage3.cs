using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3 : MonoBehaviour
{
    GameObject character;

    void Start()
    {
        Crash.die = true;
        Status.NowStage = 3;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[3];
        SoundManager.instance.audiosource.Play();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag")
        {
            SceneManager.LoadScene("gameclear");
            if (Status.Stage < 3)
                Status.Stage = 3;
            Crash.die = false;
            //Status.save();
        }
    }
}
