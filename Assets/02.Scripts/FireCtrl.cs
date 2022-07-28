using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    private AudioSource audio;
    public AudioClip fireSfx;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate(생성할 객체, 좌표, 각도)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}

/*
    AudioListener -> 1

    AudioSource  -> n
*/