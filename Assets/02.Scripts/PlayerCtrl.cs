using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;
    private float r;

    [Range(3.0f, 8.0f)]
    public float moveSpeed = 8.0f;
    public float turnSpeed = 100.0f;

    // 컴포넌트 캐시 처리할 변수를 선언
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");   // Up/Down     -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal"); // Left/Right  -1.0f ~ 0.0f ~ +1.0f
        r = Input.GetAxis("Mouse X");    // 

        // 벡터의 덧셈 연산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        // 벡터의 크기를 정규화 - 이동처리
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
        // 회전 처리
        tr.Rotate(Vector3.up * Time.deltaTime * r * turnSpeed);

    }
}
