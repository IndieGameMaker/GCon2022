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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
