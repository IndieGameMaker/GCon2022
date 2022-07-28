using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            // 충돌한 게임오브젝트(총알)을 삭제
            Destroy(coll.gameObject);
        }
    }

    /*
        충돌 콜백함수 (Collision CallBack Function)

        1) 양쪽 다 Collider Component
        2) 이동하는 객체에는 반드시 Rigidbody Component

        void OnCollisionEnter -> 1회 호출
        void OnCollisionStay  -> n번 호출
        void OnCollisionExit  -> 1회 호출 

        Is Trigger 체크된 경우

        void OnTriggerEnter/Stay/Exit
    */



}
