using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
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

    [SerializeField]
    private Transform Player;

    float x, y; //임시 저장 변수


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nogravityline")
        {
            MyRigid.constraints = RigidbodyConstraints2D.None;
            MyRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
            MoveCharacter.anim.SetBool("Wall", false);
        }
    }


    void OnCollisionStay2D(Collision2D collision) // 모서리와 충돌 이벤트
    {
        if (collision.gameObject.tag == "nogravityline")
        {
            if (MoveCharacter.Jumping) {
                if (MoveCharacter.a || MoveCharacter.b)
                {
                    if (!(MyRigid.velocity.x == 0 && MyRigid.velocity.y == 0))
                    {
                        if (Physics2D.gravity == Status.FloorVector)
                        { MyRigid.constraints = RigidbodyConstraints2D.FreezePositionY; }
                        if (Physics2D.gravity == Status.CellingVector)
                        { MyRigid.constraints = RigidbodyConstraints2D.FreezePositionY; }
                        if (Physics2D.gravity == Status.RightVector)
                        { MyRigid.constraints = RigidbodyConstraints2D.FreezePositionX; }
                        if (Physics2D.gravity == Status.LeftVector)
                        { MyRigid.constraints = RigidbodyConstraints2D.FreezePositionX; }
                        MoveCharacter.Wallsiding = true;
                        MyRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
                        MoveCharacter.anim.SetBool("Wall", true);


                        if (MoveCharacter.Jumpcount < 1)
                        {
                            MoveCharacter.Jumpcount = 1;
                        }
                        Debug.Log("벽붙음");
                    }
                }
            }
            if (!MoveCharacter.Jumping)
            {
                MyRigid.constraints = RigidbodyConstraints2D.None;
                MyRigid.constraints = RigidbodyConstraints2D.FreezeRotation;
                MoveCharacter.anim.SetBool("Wall", false);
            }
        }


        if (die)
        {
            
            if (collision.gameObject.tag == "monster") // 몬스터 충돌 이벤트
            {
                if (Status.NowStage == 0)
                    UnitCrash();

                else if (Status.NowStage > 0)
                {
                    character.transform.position = new Vector2(0, 0);
                    Physics2D.gravity = Status.FloorVector;
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
