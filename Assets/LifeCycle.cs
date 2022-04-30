using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        Vector3 vec = new Vector3(
             Input.GetAxisRaw("Horizontal") * Time.deltaTime, // Time.deltaTime : 이전 프레임의 완료까지 걸린 시간
             Input.GetAxisRaw("Vertical") * Time.deltaTime, // deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 적음
             0); // (X , Y , Z)만큼 이동
                 // 벡터 값 : 방행과 크기를 모두 가지고 있는 값
                 //int number = 4; // 스칼라 : 순수한 값
        transform.Translate(vec); // Translate : 벡터 값을 현재 위치에 더하는 함수
                                  // Vector3 : 3차원 
    }
}