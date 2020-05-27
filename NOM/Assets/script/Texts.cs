using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    public Text TimeText;

    public static float times;
    float lasttime;


    private void Start()
    {
        TimeText.text = 0.ToString();
        times = 0;
    }
    void Update()
    {
        if (Crash.die)
        {
            
            times += Time.deltaTime;
            TimeText.text = string.Format("{0:N2}", times);

        }

    }
}
