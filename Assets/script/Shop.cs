using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static int MoneyStep = 52;
    public static int[] SpeedMoney = new int[MoneyStep];
    public static int[] GoldMoney = new int[MoneyStep];
    public static int []JumpPowerMoney = new int[MoneyStep];
    public static int []DashSpeedMoney = new int[MoneyStep];
    public static int []DashTimeMoney = new int[MoneyStep];
    public static int SpeedStep = 1;
    public static int GoldStep = 1;
    public static int JumpPowerStep = 1;
    public static int DashSpeedStep = 1;
    public static int DashTimeStep = 1;
    int Plus = 0;
    int i = 0;
    public GameObject MoneyZreo;
    public GameObject StepFull;
    Text Step;
    Text Money;
    Text Step1;
    Text Money1;
    Text Step2;
    Text Money2;
    Text Step3;
    Text Money3;
    Text Step4;
    Text Money4;


    void Awake()
    {
        Step = GameObject.Find("Step").GetComponent<Text>();
        Money = GameObject.Find("Money").GetComponent<Text>();
        Step1 = GameObject.Find("Step1").GetComponent<Text>();
        Money1 = GameObject.Find("Money1").GetComponent<Text>();
        Step2 = GameObject.Find("Step2").GetComponent<Text>();
        Money2 = GameObject.Find("Money2").GetComponent<Text>();
        Step3 = GameObject.Find("Step3").GetComponent<Text>();
        Money3 = GameObject.Find("Money3").GetComponent<Text>();
        Step4 = GameObject.Find("Step4").GetComponent<Text>();
        Money4 = GameObject.Find("Money4").GetComponent<Text>();

    }

    void Start()
    {
        Plus = 100;
        SpeedMoney[1] = 100;
        GoldMoney[1] = 100;
        JumpPowerMoney[1] = 100;
        DashSpeedMoney[1] = 100;
        DashTimeMoney[1] = 100;
    
        for (i = 2; i <= 50; i++)
        {
            SpeedMoney[i] = Plus + SpeedMoney[i-1];
        }

        for (i = 2; i <= 50; i++)
            GoldMoney[i] = Plus + GoldMoney[i-1];

        for (i = 2; i <= 50; i++)
        {
            JumpPowerMoney[i] = Plus + JumpPowerMoney[i - 1];
        }
        for (i = 2; i <= 50; i++)
            DashSpeedMoney[i] = Plus + DashSpeedMoney[i-1];


        for (i = 2; i <= 50; i++)
            DashTimeMoney[i] = Plus + DashTimeMoney[i-1];


    }


    public void SpeedStatus()
    {
        
        if (Status.Money >= SpeedMoney[SpeedStep])
        {
            if (SpeedStep < MoneyStep)
            {
                Status.Speed += 0.1f;
                Status.Money -= SpeedMoney[SpeedStep];
                SpeedStep += 1;
            }
            else 
            {
                StepFull.SetActive(true);
                Invoke("falsemode", 1);

            }
        }
        else
        {
            MoneyZreo.SetActive(true);
            Invoke("falsemode", 1);
        }

        Money.text = SpeedMoney[SpeedStep].ToString();
        Step.text = Status.Speed.ToString();
    }

    public void JumpPowerStatus()
    {
        
        if (Status.Money >= JumpPowerMoney[JumpPowerStep])
        {
            if (JumpPowerStep < MoneyStep)
            {
                Status.JumpPower += 0.1f;
                Status.Money -= JumpPowerMoney[JumpPowerStep];
                JumpPowerStep += 1;
                

            }
            else
            {
                StepFull.SetActive(true);
                Invoke("falsemode", 1);

            }
        }
        else
        {
            MoneyZreo.SetActive(true);
            Invoke("falsemode", 1);
        }
        Money2.text = JumpPowerMoney[JumpPowerStep].ToString();
        Step2.text = Status.JumpPower.ToString();
    }

    public void DashSpeedStatus()
    {
        
        if (Status.Money >= DashSpeedMoney[DashSpeedStep])
        {
            if (DashSpeedStep < MoneyStep)
            {
                Status.DashPower += 0.1f;
                Status.Money -= DashSpeedMoney[DashSpeedStep];
                DashSpeedStep += 1;


            }
            else
            {
                StepFull.SetActive(true);
                Invoke("falsemode", 1);

            }
        }
        else
        {
            MoneyZreo.SetActive(true);
            Invoke("falsemode", 1);
        }

        Money3.text = DashSpeedMoney[DashSpeedStep].ToString();
        Step3.text = Status.DashPower.ToString();
    }

    public void DashTimeStatus()
    {
        
        if (Status.Money >= DashTimeMoney[DashTimeStep])
        {
            if (DashTimeStep < MoneyStep)
            {
                Status.DashCoolTime -= 0.1f;
                Status.Money -= DashTimeMoney[DashTimeStep];
                DashTimeStep += 1;


            }
            else
            {
                StepFull.SetActive(true);
                Invoke("falsemode", 1);

            }
        }
        else
        {
            MoneyZreo.SetActive(true);
            Invoke("falsemode", 1);
        }

        Money4.text = DashTimeMoney[DashTimeStep].ToString();
        Step4.text = Status.DashCoolTime.ToString();
    }


    public void GlodStatus()
    {
        
        if (Status.Money >= GoldMoney[GoldStep])
        {
            if (GoldStep < MoneyStep)
            {
                Status.GoldPlus += 0.1f;
                Status.Money -= GoldMoney[GoldStep];
                GoldStep += 1;


            }
            else
            {
                StepFull.SetActive(true);
                Invoke("falsemode", 1);

            }
        }
        else
        {
            MoneyZreo.SetActive(true);
            Invoke("falsemode", 1);
        }

        Money1.text = GoldMoney[GoldStep].ToString();
        Step1.text = Status.GoldPlus.ToString();
    }







    void falsemode()
    {
        MoneyZreo.SetActive(false);
        StepFull.SetActive(false);
    }
}



