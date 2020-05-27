using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HorizontalBlocks : MonoBehaviour
{
    [SerializeField]
    private Transform HorizontalBlock; //좌우로 움직이는 블럭

    [SerializeField]
    private float MoveTime; // 움직이는 시간

    [SerializeField]
    private Transform Player; //움직이는 캐릭터


    [SerializeField]
    private float BlockSpeed; // 블럭 속도

    float time;

    public static bool BlockRide;

    bool a, b; //a가 ture일 경우 좌측이동 또는 상승 b는 우측이동 또는 하강함

    void Start()
    {
        a = true;
        b = false;
        BlockRide = false;
        //InvokeRepeating("Reverse", BlockSpeed, BlockSpeed);
    }

    void FixedUpdate()
    {
        

        if (a)
        {
            HorizontalBlock.position += new Vector3(-1, 0, 0) * BlockSpeed * Time.deltaTime;
            if (BlockRide)
            {
                Player.position += new Vector3(-1, 0, 0) * BlockSpeed * Time.deltaTime;
            }
        }

        if (b)
        {
            HorizontalBlock.position += new Vector3(1, 0, 0) * BlockSpeed * Time.deltaTime;
            if (BlockRide)
            {
                Player.position += new Vector3(1, 0, 0) * BlockSpeed * Time.deltaTime;
            }
        }

        time += Time.deltaTime;

        if(time > MoveTime)
        {
            time = 0;
            a = !a;
            b = !b;
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "character")
        {
            BlockRide = true;
            MoveCharacter.CrashUnit = true;
            MoveCharacter.anim.SetBool("walk", false);
            MoveCharacter.anim.SetBool("stay", true);
            MoveCharacter.Jumpcount = Status.Jumpcount;
            MoveCharacter.turnjump = 0;
            MoveCharacter.a = false;
            MoveCharacter.b = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.name == "character")
        {
            BlockRide = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.name == "character")
        {
            BlockRide = false;
        }
    }

}
