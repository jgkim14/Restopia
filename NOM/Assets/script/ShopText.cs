using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopText : MonoBehaviour
{
    public Text Step;
    public Text Money;
    public Text Step1;
    public Text Money1;
    public Text Step2;
    public Text Money2;
    public Text Step3;
    public Text Money3;
    public Text Step4;
    public Text Money4;
    public Text Gold;

    /*void Start()
    {
        Money.text = Shop.SpeedMoney[Shop.SpeedStep].ToString();
        Step.text = Status.Speed.ToString();

        Money1.text = Shop.GoldMoney[Shop.GoldStep].ToString();
        Step1.text = (100 * Status.GoldPlus).ToString() + "%";

        Money2.text = Shop.JumpPowerMoney[Shop.JumpPowerStep].ToString();
        Step2.text = Status.JumpPower.ToString();

        Money3.text = Shop.DashSpeedMoney[Shop.DashSpeedStep].ToString();
        Step3.text = Status.DashPower.ToString();

        Money4.text = Shop.DashTimeMoney[Shop.DashTimeStep].ToString();
        Step4.text = Status.DashCoolTime.ToString();

        
    }*/

    void Update()
    {
        Gold.text = "소유 금액 : " + Mathf.Floor(Status.Money).ToString() + " 원";

        Money.text = Shop.SpeedMoney[Shop.SpeedStep].ToString();
        Step.text = Shop.SpeedStep.ToString();

        Money1.text = Shop.GoldMoney[Shop.GoldStep].ToString();
        Step1.text = (100 * Status.GoldPlus).ToString() + "%";

        Money2.text = Shop.JumpPowerMoney[Shop.JumpPowerStep].ToString();
        Step2.text = Shop.JumpPowerStep.ToString();

        Money3.text = Shop.DashSpeedMoney[Shop.DashSpeedStep].ToString();
        Step3.text = Shop.DashSpeedStep.ToString();

        Money4.text = Shop.DashTimeMoney[Shop.DashTimeStep].ToString();
        Step4.text = Shop.DashTimeStep.ToString();
    }

}
