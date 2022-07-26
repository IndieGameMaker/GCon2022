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

        // transform.position += new Vector3(0, 0, 0.01f);
        transform.Translate(Vector3.forward * v * 0.01f);
        transform.Translate(Vector3.right * h * 0.01f);

        /*
            Vector3.forward = Vector3(0, 0, 1)
            Vector3.up      = Vector3(0, 1, 0)
            Vector3.right   = Vector3(1, 0, 0)

            Vector3.one = Vector3(1, 1, 1)
            Vector3.zero = Vector3(0, 0, 0)
        */
    }
}
