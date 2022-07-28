using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    // 몬스터의 상태 정의
    public enum State
    {
        IDLE, TRACE, ATTACK, DIE
    }

    // 몬스터의 상태 변수
    public State state = State.IDLE;

    // 추적 사정거리
    public float traceDist = 10.0f;

    // 공격 사정거리
    public float attackDist = 2.0f;

    [SerializeField]
    private Transform monsterTr;
    [SerializeField]
    private Transform playerTr;

    // 몬스터의 사망여부
    public bool isDie = false;

    // Start is called before the first frame update
    void Start()
    {
        monsterTr = GetComponent<Transform>(); // monsterTr = transform;

        // GameObject playerObj = GameObject.FindGameObjectWithTag("PLAYER");
        // if (playerObj != null)
        // {
        //     playerTr = playerObj.GetComponent<Transform>();
        //     // playerTr = playerObj.transform;
        // }

        playerTr = GameObject.FindGameObjectWithTag("PLAYER")?.GetComponent<Transform>();

    }

    // 몬스터의 상태를 측정하는 코루틴

    // 몬스터의 상태에 따른 행동을 처리하는 코루틴

}
