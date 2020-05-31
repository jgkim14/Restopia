using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cooltime : MonoBehaviour
{

    [SerializeField]
    private Image CoolTimeIcon;
    public static float CoolTime = 0;
    bool cooltimecheck = true;

    private void FixedUpdate()
    {
        if (MoveCharacter.cooltimes)
        {
            if (cooltimecheck)
            {
                CoolTime = 0;
                cooltimecheck = false;
            }
            CoolTime += Time.deltaTime / Status.DashCoolTime;
            CoolTimeIcon.fillAmount = CoolTime;
        }
        
        if(!MoveCharacter.cooltimes)
        {
            CoolTimeIcon.fillAmount = 1;
            cooltimecheck = true;
        }
         
    }
}
