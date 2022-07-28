#pragma warning disable CS0108, IDE0052, IDE0051

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
        audio = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        // Instantiate(생성할 객체, 좌표, 각도)
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        // 총소리 발생
        audio.PlayOneShot(fireSfx, 0.8f);
    }
}

/*
    AudioListener -> 1

    AudioSource  -> n
*/