using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCharacter : MonoBehaviour
{
    [SerializeField]
    private Transform Player;

    [SerializeField]
    private ConstantForce2D Force2D;

    [SerializeField]
    private Rigidbody2D MyRigid;

    [SerializeField]
    private Text money;



    public static float Money;

    float times;

    public static bool cooltimes = false;

    public static float Jumpcount;

    public static Animator anim;

    public float rightclicktime = 0;

    public float leftclicktime = 0;


    public static bool check = false;
    public static bool celling = false;
    public static bool floor = false;
    public static bool leftside = false;
    public static bool rightside = false;
    bool rightclick = false;
    bool leftclick = false;
    public static int turnjump = 0;
    public static bool CrashUnit = false;

    public static bool a, b; //A좌 B우
    Button button;

    void Awake()
    {
        anim = GetComponent<Animator>();

        Button button = FindObjectOfType<Button>();
    }
    void Start()
    {
        Jumpcount = Status.Jumpcount;
        Crash.die = true;
        Texts.times = 0.0f;
        Money = 0.0f;
        cooltimes = false;
        times = 0;
        celling = false;
        floor = false;
        a = false;
        b = false;
        leftside = false;
        rightside = false;
        check = false;
    }


    void FixedUpdate()
    {
        money.text = Mathf.Floor(MoveCharacter.Money).ToString();

        if (a) // 오른쪽 방향키
        {
            if (Force2D.force == Status.FloorVector) // floor에 있을 경우
            {
                Player.position += new Vector3(1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                leftside = false;
                rightside = false;
                floor = true;
                celling = false;
            }
            if (Force2D.force == Status.RightVector) // right에 있을 경우
            {
                if (leftside)
                {
                    leftside = false;
                    celling = false;
                    rightside = true;
                    floor = false;
                    a = false;
                    b = true;
                }
                if (celling)
                {
                    celling = false;
                    floor = false;
                    rightside = true;
                    leftside = false;
                    a = false;
                    b = true;
                }


                Player.position += new Vector3(0, 1, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 90);

            }
            if (Force2D.force == Status.CellingVector) // celling에 있을 경우
            {
                Player.position += new Vector3(1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(-2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 180);
                if (!floor)
                {
                    if (!celling)
                    {
                        celling = true;
                        rightside = false;
                        leftside = false;
                        floor = false;
                        a = false;
                        b = true;
                    }
                }
            }
            if (Force2D.force == Status.LeftVector) // left에 있을 경우
            {
                if (rightside)
                {
                    rightside = false;
                    leftside = true;
                    floor = false;
                    celling = false;
                    a = false;
                    b = true;
                }

                if (celling)
                {
                    celling = false;
                    floor = false;
                    rightside = false;
                    leftside = true;
                    a = false;
                    b = true;
                }


                Player.position += new Vector3(0, -1, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(2, 2);
                transform.rotation = Quaternion.Euler(0, 0, -90);
               
            }
            anim.SetBool("walk", true);
            anim.SetBool("stay", false);

            if (rightclick)
            {
                rightclicktime += Time.deltaTime;
                if (rightclicktime > 0.2f)
                {
                    rightclicktime = 0;
                    rightclick = false;
                }
            }



            if (cooltimes)
            {
                times += Time.deltaTime;
                if (times >= Status.DashCoolTime)
                {
                    cooltimes = false;
                    times = 0;
                }
            }
        }

        if (b) // 왼쪽 방향키
        {
            if (Force2D.force == Status.FloorVector) // floor에 있을 경우
            {
                Player.position += new Vector3(-1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(-2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                leftside = false;
                rightside = false;
                floor = true;
                celling = false;
            }
            if (Force2D.force == Status.RightVector) // right에 있을 경우
            {
                if (leftside)
                {
                    leftside = false;
                    rightside = true;
                    floor = false;
                    celling = false;
                    a = true;
                    b = false;
                }
                if (celling)
                {
                    celling = false;
                    rightside = true;
                    leftside = false;
                    floor = false;
                    a = true;
                    b = false;
                }


                Player.position += new Vector3(0, -1, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(-2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 90);
 
            }
            if (Force2D.force == Status.CellingVector) // celling에 있을 경우
            {
                Player.position += new Vector3(-1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 180);
                if (!floor)
                {

                    if (!celling)
                    {
                        celling = true;
                        rightside = false;
                        leftside = false;
                        floor = false;
                        a = true;
                        b = false;
                    }
                }
            }
            if (Force2D.force == Status.LeftVector) // left에 있을 경우
            {
                if (rightside)
                {
                    celling = false;
                    rightside = false;
                    leftside = true;
                    floor = false;
                    a = true;
                    b = false;
                }
                if (celling)
                {
                    celling = false;
                    rightside = false;
                    leftside = true;
                    floor = false;
                    a = true;
                    b = false;
                }

                Player.position += new Vector3(0, 1, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(-2, 2);
                transform.rotation = Quaternion.Euler(0, 0, -90);

            }
            anim.SetBool("walk", true);
            anim.SetBool("stay", false);


            if (leftclick)
            {
                leftclicktime += Time.deltaTime;
                if (leftclicktime > 0.2f)
                {
                    leftclicktime = 0;
                    leftclick = false;
                }
            }

            if (cooltimes)
            {
                times += Time.deltaTime;
                if (times >= Status.DashCoolTime)
                {
                    cooltimes = false;
                    times = 0;
                }
            }


        }
    }



    public void RightMove()
    {
        MyRigid.velocity = new Vector2(MyRigid.velocity.x, MyRigid.velocity.y);
        a = true;
        b = false;
    }

    public void LeftMove()
    {
        MyRigid.velocity = new Vector2(MyRigid.velocity.x, MyRigid.velocity.y);
        a = false;
        b = true;
    }

    public void PlayerJump() // 방향에 따른 점프
    {
        if (Jumpcount > 0)
        {
            Gravity.Jumper = true;
            if (Force2D.force == Status.FloorVector)
            {
                MyRigid.velocity = new Vector2(MyRigid.velocity.x, Status.JumpPower);
            }
            if (Force2D.force == Status.RightVector)
            {
                MyRigid.velocity = new Vector2(-Status.JumpPower, MyRigid.velocity.y);
            }
            if (Force2D.force == Status.CellingVector)
            {
                MyRigid.velocity = new Vector2(MyRigid.velocity.x, -Status.JumpPower);
            }
            if (Force2D.force == Status.LeftVector)
            {
                MyRigid.velocity = new Vector2(Status.JumpPower, MyRigid.velocity.y);
            }

            if (turnjump == 1)
            {

                anim.SetBool("walk", false);
                anim.SetBool("jump", true);
                turnjump = 0;

            }
            else
                turnjump = 1;

            --Jumpcount;
            CrashUnit = false;


        }


    }


    public void PlayerLeftDash() // 유닛 대쉬
    {
        if (leftclick)
        {

            if (!cooltimes)
            {
                if (Force2D.force == Status.FloorVector)
                {
                    MyRigid.velocity = new Vector2(-Status.DashPower, 0);

                }
                if (Force2D.force == Status.RightVector)
                {
                    MyRigid.velocity = new Vector2(0, -Status.DashPower);

                }
                if (Force2D.force == Status.CellingVector)
                {
                    MyRigid.velocity = new Vector2(-Status.DashPower, 0);
                }
                if (Force2D.force == Status.LeftVector)
                {
                    MyRigid.velocity = new Vector2(0, Status.DashPower);

                }
                cooltimes = true;
            }
        }
        leftclick = true;
    }


    public void PlayerRightDash() // 유닛 오른쪽 대쉬
    {

        if (rightclick)
        {
            if (!cooltimes)
            {

                if (Force2D.force == Status.FloorVector)
                {
                    MyRigid.velocity = new Vector2(Status.DashPower, 0);

                }
                if (Force2D.force == Status.RightVector)
                {
                    MyRigid.velocity = new Vector2(0, Status.DashPower);


                }
                if (Force2D.force == Status.CellingVector)
                {
                    MyRigid.velocity = new Vector2(Status.DashPower, 0);
                   
                }
                if (Force2D.force == Status.LeftVector)
                {
                    MyRigid.velocity = new Vector2(0, -Status.DashPower);

                }
                cooltimes = true;
            }
        }
        rightclick = true;
    }



    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" || collision.gameObject.tag == "leftwall")
        {
            CrashUnit = false;
        }


    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" || collision.gameObject.tag == "leftwall")
        {
            CrashUnit = true;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" || collision.gameObject.tag == "leftwall")
        {
            CrashUnit = true;
            MoveCharacter.anim.SetBool("jump", false);
            MoveCharacter.Jumpcount = Status.Jumpcount;
            MyRigid.velocity = new Vector2(0, 0);
            turnjump = 0;

        }
        

    }

}
