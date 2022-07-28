using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            // 충돌한 게임오브젝트(총알)을 삭제
            Destroy(coll.gameObject);

            // 충돌 정보를 저장 (첫번째 충돌정보)
            ContactPoint cp = coll.GetContact(0);
            // 충돌 좌표
            Vector3 _point = cp.point;
            // 법선 벡터
            Vector3 _normal = -cp.normal;
            // 벡터를 Quaternion 타입으로 변환
            Quaternion rot = Quaternion.LookRotation(_normal);

            GameObject spark = Instantiate(sparkEffect, _point, rot);
            Destroy(spark, 0.4f);
        }
    }
    /*
        Quaternion (쿼터니언 , 사원수) -> x, y, z, w
        짐벌락(Gimbal Lock : 김벌락)

        Quaternion.Euler(0, 45, 30)
        Quaternion.LookRotation(벡터)
        오일러 회전 (Euler Rotation) x -> y -> z
    
    */



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
