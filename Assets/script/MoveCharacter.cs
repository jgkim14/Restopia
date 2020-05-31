using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    public static bool sideJump = true;
    public static bool Jumping = false;
    public static bool Wallsiding = false;

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
        sideJump = true;
        Jumping = false;
}


    void FixedUpdate()
    {
        Debug.Log(Jumpcount);
        //money.text = Mathf.Floor(MoveCharacter.Money).ToString();
        if (Physics2D.gravity == Status.FloorVector) // 바닥면에 붙어있을 경우 캐릭터의 기울기
        { transform.rotation = Quaternion.Euler(0, 0, 0);}

        else if (Physics2D.gravity == Status.RightVector) // 오른쪽에 붙어있을경우 캐릭터의 기울기
        { transform.rotation = Quaternion.Euler(0, 0, 90); }

        else if (Physics2D.gravity == Status.LeftVector) // 왼쪽에 붙어있을경우 캐릭터의 기울기
        { transform.rotation = Quaternion.Euler(0, 0, -90); }

        else if (Physics2D.gravity == Status.CellingVector) // 천장에 붙어있을경우 캐릭터의 기울기
        { transform.rotation = Quaternion.Euler(0, 0, 180); }


        if (a) // 오른쪽 방향키
        {
            if (Physics2D.gravity == Status.FloorVector) // floor에 있을 경우
            {
                Player.position += new Vector3(1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(2, 2);
                //transform.rotation = Quaternion.Euler(0, 0, 0);
                leftside = false;
                rightside = false;
                floor = true;
                celling = false;
            }
            if (Physics2D.gravity == Status.RightVector) // right에 있을 경우
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
                //transform.rotation = Quaternion.Euler(0, 0, 90);

            }
            if (Physics2D.gravity == Status.CellingVector) // celling에 있을 경우
            {
                Player.position += new Vector3(1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(-2, 2);
                //transform.rotation = Quaternion.Euler(0, 0, 180);
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
            if (Physics2D.gravity == Status.LeftVector) // left에 있을 경우
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
               // transform.rotation = Quaternion.Euler(0, 0, -90);
               
            }
            anim.SetBool("walk", true);
            anim.SetBool("stay", false);


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
            if (Physics2D.gravity == Status.FloorVector) // floor에 있을 경우
            {
                Player.position += new Vector3(-1, 0, 0) * Status.Speed * Time.deltaTime;
                transform.localScale = new Vector2(-2, 2);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                leftside = false;
                rightside = false;
                floor = true;
                celling = false;
            }
            if (Physics2D.gravity == Status.RightVector) // right에 있을 경우
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
            if (Physics2D.gravity == Status.CellingVector) // celling에 있을 경우
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
            if (Physics2D.gravity == Status.LeftVector) // left에 있을 경우
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
        }
    }

    public void MoveStop()
    {
        anim.SetBool("walk", false);
        anim.SetBool("stay", true);

        a = false;
        b = false;

    }

    public void RightMove()
    {
        //MyRigid.velocity = new Vector2(MyRigid.velocity.x, MyRigid.velocity.y);
        a = true;
        b = false;
    }

    public void LeftMove()
    {
        //MyRigid.velocity = new Vector2(MyRigid.velocity.x, MyRigid.velocity.y);
        a = false;
        b = true;
    }

    public void PlayerJump() // 방향에 따른 점프
    {
        if (Jumpcount > 0)
        {
            if (!Wallsiding)
            {
                if (Physics2D.gravity == Status.FloorVector)
                {
                    MyRigid.velocity = new Vector2(MyRigid.velocity.x, Status.JumpPower);
                }
                if (Physics2D.gravity == Status.RightVector)
                {
                    MyRigid.velocity = new Vector2(-Status.JumpPower, MyRigid.velocity.y);
                }
                if (Physics2D.gravity == Status.CellingVector)
                {
                    MyRigid.velocity = new Vector2(MyRigid.velocity.x, -Status.JumpPower);
                }
                if (Physics2D.gravity == Status.LeftVector)
                {
                    MyRigid.velocity = new Vector2(Status.JumpPower, MyRigid.velocity.y);
                }
            }



            /*if (turnjump == 1)
            {

                anim.SetBool("walk", false);
                anim.SetBool("jump", true);
                turnjump = 0;

            }
            else
                turnjump = 1; */ 

            --Jumpcount;
            CrashUnit = false;
            Jumping = true;

        }


    }



    public void Dashing() // 캐릭터 대쉬
    {
        if (!cooltimes)
        {
            if (transform.localScale == new Vector3(-2, 2, 0)) // 좌측을 보고 있을 경우
            {
                if (Physics2D.gravity == Status.FloorVector)
                {
                    MyRigid.velocity = new Vector2(transform.localScale.x * Status.DashPower, 0);

                }
                if (Physics2D.gravity == Status.RightVector)
                {
                    MyRigid.velocity = new Vector2(0, transform.localScale.x * Status.DashPower);

                }
                if (Physics2D.gravity == Status.CellingVector)
                {
                    MyRigid.velocity = new Vector2(-transform.localScale.x * Status.DashPower, 0);
                }
                if (Physics2D.gravity == Status.LeftVector)
                {
                    MyRigid.velocity = new Vector2(0, -transform.localScale.x * Status.DashPower);
                }
                StartCoroutine("Cooldown");
            }

            else if (transform.localScale == new Vector3(2, 2, 0)) // 우측을 보고 있을 경우
            {
                if (Physics2D.gravity == Status.FloorVector)
                {
                    MyRigid.velocity = new Vector2(transform.localScale.x * Status.DashPower, 0);

                }
                if (Physics2D.gravity == Status.RightVector)
                {
                    MyRigid.velocity = new Vector2(0, transform.localScale.x * Status.DashPower);

                }
                if (Physics2D.gravity == Status.CellingVector)
                {
                    MyRigid.velocity = new Vector2(-transform.localScale.x * Status.DashPower, 0);
                }
                if (Physics2D.gravity == Status.LeftVector)
                {
                    MyRigid.velocity = new Vector2(0, -transform.localScale.x * Status.DashPower);
                }
                StartCoroutine("Cooldown");
            }

           
        }
    }


    IEnumerator Cooldown() // 대쉬 쿨타임 설정
    {
        if (!cooltimes) 
        {
            cooltimes = true;
            yield return new WaitForSeconds(1f); //쿨타임 1초로 설정
            cooltimes = false;
            Debug.Log("쿨타임임");
        }
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
            Jumping = false;
            CrashUnit = true;
            turnjump = 0;
            sideJump = true;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "rightwall" || collision.gameObject.tag == "celling" || collision.gameObject.tag == "leftwall")
        {
            CrashUnit = true;
            Jumpcount = Status.Jumpcount;
            MyRigid.velocity = new Vector2(0, 0);
            turnjump = 0;
            sideJump = true;
            Jumping = false;

        }
        if(collision.gameObject.tag == "moveblocks")
        {
            CrashUnit = true;
            MoveCharacter.anim.SetBool("walk", false);
            MoveCharacter.anim.SetBool("stay", true);
            MoveCharacter.Jumpcount = Status.Jumpcount;
            MyRigid.velocity = new Vector2(0, 0);
            turnjump = 0;
            Jumping = false;
        }

        

    }

}
