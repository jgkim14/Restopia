using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public static bool Pause = true;

    public Sprite Stopon;
    public Sprite Stopoff;
    public Image StopImage;

    Crash crash;
    public GameObject menu;

    SoundManager soundmanager;

    bool timeset = false;

    [SerializeField]
    private Image ButtonA;

    [SerializeField]
    private Image ButtonD;

    void Awake()
    {
        Crash crash = FindObjectOfType<Crash>();
        SoundManager soundmanager = FindObjectOfType<SoundManager>();

    }

    public void Mainmenu()
    {
        
        SceneManager.LoadScene("mainmenu");
        SoundManager.instance.GameSound("MainTheme");
        Time.timeScale = 1;
        Crash.die = false;
        Pause = true;
    }
    public void StageChoice()
    {
        SceneManager.LoadScene("StageChoice");
        SoundManager.instance.GameSound("MainTheme");
        Time.timeScale = 1;
        Crash.die = false;
        Pause = true;
        //SaveLoad.Saving();

    }

    public void Shop()
    {
        SceneManager.LoadScene("shop");


    }

    /*public void Exit()
    {
        Application.Quit();
        /aveLoad.Saving();

    }*/

    public void MoneySave()
    {
        Status.Money += MoveCharacter.Money;
        MoveCharacter.Money = 0;
    }

    public void Retry() // 스테이지 별로 리트라이버튼
    {
        //SaveLoad.Saving();
        switch (Status.NowStage)
        {
            case 0:
                SceneManager.LoadScene("stage0"); break;
            case 1:
                SceneManager.LoadScene("stage1"); break;
            case 2:
                SceneManager.LoadScene("stage2"); break;
            case 3:
                SceneManager.LoadScene("stage3"); break;
            case 4:
                SceneManager.LoadScene("stage4"); break;
            case 5:
                SceneManager.LoadScene("stage5"); break;
            case 6:
                SceneManager.LoadScene("stage6"); break;
            case 7:
                SceneManager.LoadScene("stage7"); break;
            case 8:
                SceneManager.LoadScene("stage8"); break;
            case 9:
                SceneManager.LoadScene("stage9"); break;
            case 10:
                SceneManager.LoadScene("stage10"); break;
            case 11:
                SceneManager.LoadScene("TEST stage"); break;
            case 12:
                SceneManager.LoadScene("TEST Stage1_Muks"); break;
            case 13:
                SceneManager.LoadScene("TEST Stage2_Muks"); break;

        }

        Crash.die = true;
        Texts.times = 0;
        Time.timeScale = 1;
        Pause = true;

    }

    public void Stage0()
    {
        Status.NowStage = 0;
        SceneManager.LoadScene("Stage0");
    }

    public void Stage1()
    {
        Status.NowStage = 1;

        SceneManager.LoadScene("Stage1");
    }
    public void Stage2()
    {

        Status.NowStage = 2;
        SceneManager.LoadScene("Stage2");
    }

    public void Stage3()
    {

        Status.NowStage = 3;
        SceneManager.LoadScene("Stage3");
    }
    public void Stage4()
    {

        Status.NowStage = 4;
        SceneManager.LoadScene("Stage4");
    }
    public void Stage5()
    {

        Status.NowStage = 5;
        SceneManager.LoadScene("Stage5");
    }

    public void Stage6()
    {

        Status.NowStage = 6;
        SceneManager.LoadScene("Stage6");
    }

    public void Stage7()
    {

        Status.NowStage = 7;
        SceneManager.LoadScene("Stage7");
    }

    public void Stage8()
    {

        Status.NowStage = 8;
        SceneManager.LoadScene("Stage8");
    }

    public void Stage9()
    {

        Status.NowStage = 9;
        SceneManager.LoadScene("Stage9");
    }

    public void Stage10()
    {

        Status.NowStage = 10;
        SceneManager.LoadScene("Stage10");
    }

    public void TESTStage0()
    {

        Status.NowStage = 11;
        SceneManager.LoadScene("TEST stage");
    }

    public void TESTStage1()
    {

        Status.NowStage = 12;
        SceneManager.LoadScene("TEST stage1_Muks");
    }

    public void TESTStage2()
    {

        Status.NowStage = 13;
        SceneManager.LoadScene("TEST stage2_Muks");
    }
    public void TESTStageChoice()
    {
        SceneManager.LoadScene("TEST StageChoice");
        SoundManager.instance.GameSound("MainTheme");
        Time.timeScale = 1;
        Crash.die = false;
        Pause = true;
        //SaveLoad.Saving();

    }




    public void gamestopbutton()  //일시정지 버튼
    {
        if (Crash.die)
        {
            if (Pause)
            {
                menu.gameObject.SetActive(true);
                Pause = false;
                Time.timeScale = 0;
                SoundManager.instance.audiosource.Pause();
                StopImage.sprite = Stopon;
            }
            else
            {
                Pause = true;
                Time.timeScale = 1;
                menu.gameObject.SetActive(false);
                SoundManager.instance.audiosource.Play();
                StopImage.sprite = Stopoff;
            }
            
        }
    }
}

 
