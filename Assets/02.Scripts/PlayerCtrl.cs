using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");   // Up/Down     -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal"); // Left/Right  -1.0f ~ 0.0f ~ +1.0f

        // 벡터의 덧셈 연산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        transform.Translate(moveDir * 0.01f);
    }
}
