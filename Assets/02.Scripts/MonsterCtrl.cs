using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

    private NavMeshAgent agent;

    // 몬스터의 사망여부
    public bool isDie = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        monsterTr = GetComponent<Transform>(); // monsterTr = transform;

        // GameObject playerObj = GameObject.FindGameObjectWithTag("PLAYER");
        // if (playerObj != null)
        // {
        //     playerTr = playerObj.GetComponent<Transform>();
        //     // playerTr = playerObj.transform;
        // }

        playerTr = GameObject.FindGameObjectWithTag("PLAYER")?.GetComponent<Transform>();

        StartCoroutine(CheckMonsterState());
    }

    // 몬스터의 상태를 측정하는 코루틴
    IEnumerator CheckMonsterState()
    {
        while (!isDie)
        {
            // 주인공과 몬스터간의 거리를 계산
            float dist = Vector3.Distance(monsterTr.position, playerTr.position);

            if (dist <= attackDist)
            {
                state = State.ATTACK;
            }
            else if (dist <= traceDist)
            {
                state = State.TRACE;
            }
            else
            {
                state = State.IDLE;
            }


            yield return new WaitForSeconds(0.3f);
        }
    }

    // 몬스터의 상태에 따른 행동을 처리하는 코루틴
    IEnumerator MonsterAction()
    {
        while (!isDie)
        {
            switch (state)
            {
                case State.IDLE:
                    break;

                case State.TRACE:
                    break;

                case State.ATTACK:
                    break;

                case State.DIE:
                    break;
            }
            yield return new WaitForSeconds(0.3f);
        }
    }

}
