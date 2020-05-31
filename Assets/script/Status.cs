using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{


    public static float Life = 1;
    public static float Speed = 10.0f;
    public static float DashPower = 10.0f;
    public static float Jumpcount = 2.0f;
    public static float JumpPower = 12.0f;
    public static float DashCoolTime = 5.0f;
    public static float GoldPlus = 1;
    public static float Money = 10000;
    public static int NextStage = 1;
    public static int NowStage = 1;
    public static bool[] stage = new bool[20];
    public static int Stage = 0;
    public static float[] Besttime = new float[10];
    public static int StageNumber = 10;
    



    public static Vector2 FloorVector = new Vector2(0.0f, -25f);

    public static Vector2 RightVector = new Vector2(25f, 0f);

    public static Vector2 CellingVector = new Vector2(0.0f, 25f);

    public static Vector2 LeftVector = new Vector2(-25f, 0f);


    //[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void FirstLoad()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Screen.SetResolution(1280, 720, true);

        

    }

    private void Start()
    {
        Speed = 8.5f;
        DashPower = 10.0f;
        Jumpcount = 2.0f;
        JumpPower = 9.0f;
        DashCoolTime = 5.0f;
        GoldPlus = 1;
        Money = 10000;
        NextStage = 1;
        NowStage = 1;


        /*if (PlayerPrefs.HasKey("PlayerMoney"))
            SaveLoad.Loading();
            */
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            //SaveLoad.Saving();
        }
    }


    /*public static void loaddata()
    {
        Money = PlayerPrefs.GetInt("PlayerMoney");
        Speed = PlayerPrefs.GetFloat("PlayerSpeed");
        DashPower = PlayerPrefs.GetFloat("PlayerDashPower");
        JumpPower = PlayerPrefs.GetFloat("PlayerJumpPower");
        DashCoolTime = PlayerPrefs.GetFloat("PlayerDashCoolTime");
        GoldPlus = PlayerPrefs.GetFloat("PlayerGoldPlus");
        Stage = PlayerPrefs.GetInt("PlayerStage");
        Shop.SpeedStep = PlayerPrefs.GetInt("PlayerSpeedStep");
        Shop.GoldStep = PlayerPrefs.GetInt("PlayerGoldStep");
        Shop.JumpPowerStep = PlayerPrefs.GetInt("PlayerJumpPowerStep");
        Shop.DashSpeedStep = PlayerPrefs.GetInt("PlayerDashSpeedStep");
        Shop.DashTimeStep = PlayerPrefs.GetInt("PlayerDashTimeStep");
    }

    public static void savedata()
    {
        PlayerPrefs.SetFloat("PlayerSpeed", Speed);
        PlayerPrefs.SetFloat("PlayerDashPower", DashPower);
        PlayerPrefs.SetFloat("PlayerJumpPower", JumpPower);
        PlayerPrefs.SetFloat("PlayerDashCoolTime", DashCoolTime);
        PlayerPrefs.SetFloat("PlayerGoldPlus", GoldPlus);
        PlayerPrefs.SetInt("PlayerMoney", Money);
        PlayerPrefs.SetInt("PlayerStage", Stage);
        PlayerPrefs.SetInt("PlayerSpeedStep", Shop.SpeedStep);
        PlayerPrefs.SetInt("PlayerGoldStep", Shop.GoldStep);
        PlayerPrefs.SetInt("PlayerJumpPowerStep", Shop.JumpPowerStep);
        PlayerPrefs.SetInt("PlayerDashSpeedStep", Shop.DashSpeedStep);
        PlayerPrefs.SetInt("PlayerDashTimeStep", Shop.DashTimeStep);
        PlayerPrefs.Save();
    }*/



}
