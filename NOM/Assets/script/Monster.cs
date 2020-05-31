using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private float MonsterSpeed;

    [SerializeField]
    private Rigidbody2D MyRigid;

    public GameObject unit;

    float x, y;

    private void Start()
    {

        MonsterSpeed = 7;


        x = 0;
        y = 0;
        while (x == 0)
        {
            x = Random.Range(-1.0f, 1.0f);
        }


        while (y == 0)
        {
            y = Random.Range(-1, 2);
        }

        Vector2 JumpVelocity = new Vector2(x, y);

        MyRigid.AddForce(JumpVelocity * MonsterSpeed, ForceMode2D.Impulse);

    }


}
