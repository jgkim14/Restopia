using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage5 : MonoBehaviour
{
    GameObject character;

    private void Start()
    {
        Crash.die = true;
        Status.NowStage = 5;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[5];
        SoundManager.instance.audiosource.Play();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag")
        {
            SceneManager.LoadScene("gameclear");
            if (Status.Stage < 5)
                Status.Stage = 5;
            Crash.die = false;
            //Status.save();s
        }
    }
}
