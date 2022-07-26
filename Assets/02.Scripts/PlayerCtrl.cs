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
        v = Input.GetAxis("Vertical");  // Up/Down  -1.0f ~ 0.0f ~ +1.0f
        Debug.Log("v=" + v);

        // transform.position += new Vector3(0, 0, 0.01f);
        transform.Translate(Vector3.forward * 0.01f);
    }
}
