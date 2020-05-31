using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagers : MonoBehaviour
{
    Button button = FindObjectOfType<Button>();
    Crash crash = FindObjectOfType<Crash>();

    void Update()
    {
        if (Crash.die)
        {
            if (Button.Pause)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.SetActive(true);
            };

        }
    }


}
