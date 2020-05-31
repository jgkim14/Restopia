using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.Animations;

public class Crash : MonoBehaviour
{
    public Text money;

    public static bool die = true; //피격

    [SerializeField]
    private Rigidbody2D MyRigid;

    [SerializeField]
    private GameObject character;

    [SerializeField]
    private ConstantForce2D Force2D;

    void OnCollisionEnter2D(Collision2D collision) // 모서리와 충돌 이벤트
    {

        if (die)
        {

            if (collision.gameObject.tag == "monster") // 몬스터 충돌 이벤트
            {
                if (Status.NowStage == 0)
                    UnitCrash();

                else if (Status.NowStage > 0)
                {
                    character.transform.position = new Vector2(0, 0);
                    Force2D.force = Status.FloorVector;
                    character.transform.rotation = Quaternion.Euler(0, 0, 0);
                    MyRigid.velocity = new Vector2(0, 0);
                    MoveCharacter.a = false;
                    MoveCharacter.b = false;
                    MoveCharacter.anim.SetBool("stay", true);
                    MoveCharacter.anim.SetBool("walk", false);
                }
            }

        }
    }



    public static void UnitCrash()
    {
        die = false;
        Status.Money += MoveCharacter.Money;
        MoveCharacter.Money = 0;
        SceneManager.LoadScene("gameover");
    }
}
