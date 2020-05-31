using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stagemanager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] StageButton;

    public static bool[] StageOpen = new bool[10];
    public void Update()
    {

        for(int i = 0; i <= Status.Stage; i++)
        {
            StageOpen[i + 1] = true;
            StageButton[i+1].SetActive(true);
        }
        
    }

}
