using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage9 : MonoBehaviour
{
    GameObject character;

    private void Start()
    {
        Crash.die = true;
        Status.NowStage = 9;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[9];
        SoundManager.instance.audiosource.Play();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag")
        {
            SceneManager.LoadScene("gameclear");
            if (Status.Stage < 9)
                Status.Stage = 9;
            Crash.die = false;
        }
    }
}
