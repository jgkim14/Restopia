using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2 : MonoBehaviour
{


    GameObject character;

    [SerializeField]
    private Rigidbody2D MyRigid;

    void Start()
    {
        Crash.die = true;
        Status.NowStage = 2;
        character = gameObject;
        SoundManager.instance.audiosource.Stop();
        SoundManager.instance.audiosource.clip = SoundManager.instance.Stage[2];
        SoundManager.instance.audiosource.Play();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "flag1")
        {
            gameObject.transform.position = new Vector2(80, -9.5f);
            MyRigid.velocity = new Vector2(0, 0);
        }
        if (collision.gameObject.name == "flag2")
            gameObject.transform.position = new Vector2(143, -9.5f);

        if (collision.gameObject.name == "flag3")
            gameObject.transform.position = new Vector2(25, -58f);

        if (collision.gameObject.name == "flag4")
            gameObject.transform.position = new Vector2(80, -61.5f);

        if (collision.gameObject.name == "flag5")
        {
            SceneManager.LoadScene("gameclear");
            if (Status.Stage < 2)
                Status.Stage = 2;
            Crash.die = false;
            //Status.save();
        }
    }
}
