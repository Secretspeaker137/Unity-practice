using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // 1.MoveTowards
        transform.position =
            Vector3.MoveTowards(transform.position // MoveTowards : 등속 이동
                               , target, 2f);      // 매개변수는 (현재위치, 목표위치, 속도)로 구성
                                                   // 마지막 매개변수에 비례하여 속도 증가     
        // 2. SmoothDamp 
        Vector3 velo = Vector3.zero; // 속도

        transform.position =
            Vector3.SmoothDamp(transform.position // SmoothDamp : 부드러운 감속 이동
                               , target, ref velo, 0.1f); // 매개변수는 (현재위치, 목표위치, 참조 속도, 속도)
                                                          // 마지막 매개변수에 반비례하여 속도 증가
                                                          // ref : 참조 접근 -> 실시간으로 바뀌는 값 적용 가능
    }
}