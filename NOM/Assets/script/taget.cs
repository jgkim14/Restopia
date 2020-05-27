using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taget : MonoBehaviour
{
    public Transform tagets;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = tagets.position - transform.position;  // 타겟 의 위치 와 자신의 위치를 뺀다.
        dir.Normalize(); // 노멀라이즈 시켜 방향성을 가진다.
        Quaternion q = Quaternion.identity; // 쿼터니언 객체를 만든다.
        q.SetLookRotation(dir, Vector3.up);//(방향값, 회전 축 ) 
        transform.rotation = q; // 쿼터니언 값을 객체의 로테이션에 넣어준다.
    }
}
