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

    [SerializeField]
    private MeshRenderer muzzleFlash;

    void Start()
    {
        audio = this.gameObject.GetComponent<AudioSource>();
        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
        muzzleFlash.enabled = false;
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

        StartCoroutine(ShowMuzzleFlash());
    }

    IEnumerator ShowMuzzleFlash()
    {
        // Texture Offset 변경
        // (0, 0) , (0.5, 0), (0.5, 0.5), (0, 0.5)
        Vector2 offset = new Vector2(Random.Range(0, 2) * 0.5f, Random.Range(0, 2) * 0.5f);
        muzzleFlash.material.mainTextureOffset = offset;

        // Texture 회전
        float angle = Random.Range(0, 360);
        muzzleFlash.transform.localRotation = Quaternion.Euler(Vector3.forward * angle);
        //muzzleFlash.transform.localRotation = Quaternion.Euler(0, 0, angle);

        // Texture Scale 변경
        float scale = Random.Range(1.0f, 2.5f);
        muzzleFlash.transform.localScale = Vector3.one * scale;
        //muzzleFlash.transform.localScale = new Vector3(scale, scale, scale);

        // Muzzle 활성화
        muzzleFlash.enabled = true;

        // Waiting ... / Sleep
        yield return new WaitForSeconds(0.3f);

        // Muzzle 비활성화
        muzzleFlash.enabled = false;
    }
}

/*
    AudioListener -> 1

    AudioSource  -> n
*/

/*
    Co-routine 코루틴

*/