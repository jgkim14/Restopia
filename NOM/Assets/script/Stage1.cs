using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour
{
    int Stage;
    GameObject character;

    void Start()
    {
        Crash.die = true;
        Status.NowStage = 1;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[1];
        SoundManager.instance.audiosource.Play();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag1")
            gameObject.transform.position = new Vector2(95, 7.6f);

        if (collision.gameObject.name == "flag2")
            gameObject.transform.position = new Vector2(-7, -98);

        if (collision.gameObject.name == "flag3")
            gameObject.transform.position = new Vector2(60, -99);

        if (collision.gameObject.name == "flag4")
            gameObject.transform.position = new Vector2(227, -82);

        if (collision.gameObject.name == "flag5")
        {
            SceneManager.LoadScene("gameclear");
            if (Status.Stage < 1)
                Status.Stage = 1;
            Crash.die = false;
            //Status.save();
        }

    }

}
