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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
