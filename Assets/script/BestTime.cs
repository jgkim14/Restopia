using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTime : MonoBehaviour
{

    [SerializeField]
    private Text Besttime;

    [SerializeField]
    private Text Lasttime;
    void Start()
    {
        if (Status.Besttime[Status.NowStage] < 10)
            Status.Besttime[Status.NowStage] = Texts.times;
       
        else if (Status.Besttime[Status.NowStage] > Texts.times)
        {
            Status.Besttime[Status.NowStage] = Texts.times;
        }

        Besttime.text = string.Format("{0:N2}",Status.Besttime[Status.NowStage]);

        Lasttime.text = string.Format("{0:N2}", Texts.times);

    }
}
