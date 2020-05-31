using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage8 : MonoBehaviour
{
    GameObject character;

    private void Start()
    {
        Crash.die = true;
        Status.NowStage = 8;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[8];
        SoundManager.instance.audiosource.Play();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag")
        {
            SceneManager.LoadScene("gameclear");
            if (Status.Stage < 8)
                Status.Stage = 8;
            Crash.die = false;
        }
    }
}
