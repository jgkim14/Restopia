using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SaveLoad : MonoBehaviour
{



    public static void Loading()
    {
        Status.Money = PlayerPrefs.GetFloat("PlayerMoney");
        Status.Speed = PlayerPrefs.GetFloat("PlayerSpeed");
        Status.DashPower = PlayerPrefs.GetFloat("PlayerDashPower");
        Status.JumpPower = PlayerPrefs.GetFloat("PlayerJumpPower");
        Status.DashCoolTime = PlayerPrefs.GetFloat("PlayerDashCoolTime");
        Status.GoldPlus = PlayerPrefs.GetFloat("PlayerGoldPlus");
        Status.Stage = PlayerPrefs.GetInt("PlayerStage");
        Shop.SpeedStep = PlayerPrefs.GetInt("PlayerSpeedStep");
        Shop.GoldStep = PlayerPrefs.GetInt("PlayerGoldStep");
        Shop.JumpPowerStep = PlayerPrefs.GetInt("PlayerJumpPowerStep");
        Shop.DashSpeedStep = PlayerPrefs.GetInt("PlayerDashSpeedStep");
        Shop.DashTimeStep = PlayerPrefs.GetInt("PlayerDashTimeStep");
    }

    public static void Saving()
    {
        PlayerPrefs.SetFloat("PlayerSpeed", Status.Speed);
        PlayerPrefs.SetFloat("PlayerDashPower", Status.DashPower);
        PlayerPrefs.SetFloat("PlayerJumpPower", Status.JumpPower);
        PlayerPrefs.SetFloat("PlayerDashCoolTime", Status.DashCoolTime);
        PlayerPrefs.SetFloat("PlayerGoldPlus", Status.GoldPlus);
        PlayerPrefs.SetFloat("PlayerMoney", Status.Money);
        PlayerPrefs.SetInt("PlayerStage", Status.Stage);
        PlayerPrefs.SetInt("PlayerSpeedStep", Shop.SpeedStep);
        PlayerPrefs.SetInt("PlayerGoldStep", Shop.GoldStep);
        PlayerPrefs.SetInt("PlayerJumpPowerStep", Shop.JumpPowerStep);
        PlayerPrefs.SetInt("PlayerDashSpeedStep", Shop.DashSpeedStep);
        PlayerPrefs.SetInt("PlayerDashTimeStep", Shop.DashTimeStep);
        PlayerPrefs.Save();
    }
}
