using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start() 
    {
        // 코드 흐름은 선언 > 초기화 > 호출 

        rigid = GetComponent<Rigidbody>(); // GetComponent<T> : 자신의 타입 컨포넌트를 가져옴.
        //rigid.AddForce(Vector3.up * 50, // AddForce(Vec) : Vec의 방향과 크기로 힘을 줌. 
            //ForceMode.Impulse); // ForceMode : 힘을 주는 방식(가속, 무게 반영) // 점프할 때 Impulse 사용
                                // Mass 무게 값이 클수록 움직이는데 더 많은 힘이 필요.

        //rigid.velocity = Vector3.right; // 오른쪽으로 쭉 // velocity(vector3) : 현재 이동 속도 
        //rigid.velocity = Vector3.left; // 왼쪽으로 쭉
        //rigid.velocity = new Vector3(2, 3, -1); // 정해진 위치로 튀어오름
        // 2D 컨포넌트 > 3D > 에러
        // 3D 컨포넌트 > 2D > 에러
    }

    void Update()
    {
        //rigid.velocity = new Vector3(2, 3, -1); // 공중으로 따오름
    }

    void FixedUpdate() // RigidBody 관련 코드는 FixedUpdate에 작성!
    {
        //rigid.velocity = new Vector3(2, 3, -1); // 공중으로 따오름

        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); // AddForce의 힘 방향으로 계속 속도 velocity가 증가.
        //    //Debug.Log(rigid.velocity);
        //}

        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
        //                          0, 
        //                          Input.GetAxisRaw("Vertical"));

        //rigid.AddForce(vec, ForceMode.Impulse);

        // 회전하기

        //rigid.AddTorque(Vector3.back); // 뒤로 회전 // AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김.
        //rigid.AddTorque(Vector3.up); // 제자리에서 왼쪽으로 회전 // Vec를 축으로 삼기 때문에 이동 방향에 주의!
        rigid.AddTorque(Vector3.down); // 제자리에서 오른쪽으로 회전
    }
}
