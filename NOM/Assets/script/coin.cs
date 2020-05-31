using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class coin : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D MyRigid;

    [SerializeField]
    private GameObject Coin;

    float x, y;

    float CoinSpeed = 5;

    void Start()
    {

        float x = 0;
        float y = 0;
        while (x == 0)
        {
            x = Random.Range(-1, 2);
        }


        while (y == 0)
        {
            y = Random.Range(-1, 2);
        }

        Vector2 JumpVelocity = new Vector2(x, y);
        MyRigid.velocity = new Vector2(x*CoinSpeed,y*CoinSpeed);

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            Destroy(Coin);
            MoveCharacter.Money += 100 * Status.GoldPlus;
        }

    }


    /*id Coins()
    {
        x = Random.Range(-15f, 15f);
        y = Random.Range(-8f, 8f);

        Instantiate(Coin, new Vector3(x, y, 1), Quaternion.identity);
    }*/


}
