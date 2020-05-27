using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{


    public  AudioSource audiosource;
    public  AudioClip MainTheme;
    public  AudioClip []Stage;

    public GameObject Main;

    public string soundclip = "MainTheme";

    public static SoundManager instance;   //변수 선언부// 

    void Awake()
    {
        SoundManager.instance = this;  //변수 초기화부 // 
    }

        void Start()
    {
        audiosource.clip = MainTheme;
        audiosource.Play();
    }


    public void GameSound(string name)
    {
        if (name == "MainTheme")
        {
            audiosource.clip = MainTheme;
            audiosource.Play();
        }

    }

  /* public void StartSound()
    {
        Invoke("GameSound", 3);
        audiosource.Play();
    } */

}
