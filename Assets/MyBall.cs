using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start() 
    {
        // �ڵ� �帧�� ���� > �ʱ�ȭ > ȣ�� 

        rigid = GetComponent<Rigidbody>(); // GetComponent<T> : �ڽ��� Ÿ�� ������Ʈ�� ������.
        //rigid.AddForce(Vector3.up * 50, // AddForce(Vec) : Vec�� ����� ũ��� ���� ��. 
            //ForceMode.Impulse); // ForceMode : ���� �ִ� ���(����, ���� �ݿ�) // ������ �� Impulse ���
                                // Mass ���� ���� Ŭ���� �����̴µ� �� ���� ���� �ʿ�.

        //rigid.velocity = Vector3.right; // ���������� �� // velocity(vector3) : ���� �̵� �ӵ� 
        //rigid.velocity = Vector3.left; // �������� ��
        //rigid.velocity = new Vector3(2, 3, -1); // ������ ��ġ�� Ƣ�����
        // 2D ������Ʈ > 3D > ����
        // 3D ������Ʈ > 2D > ����
    }

    void Update()
    {
        //rigid.velocity = new Vector3(2, 3, -1); // �������� ������
    }

    void FixedUpdate() // RigidBody ���� �ڵ�� FixedUpdate�� �ۼ�!
    {
        //rigid.velocity = new Vector3(2, 3, -1); // �������� ������

        //if (Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); // AddForce�� �� �������� ��� �ӵ� velocity�� ����.
        //    //Debug.Log(rigid.velocity);
        //}

        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
        //                          0, 
        //                          Input.GetAxisRaw("Vertical"));

        //rigid.AddForce(vec, ForceMode.Impulse);

        // ȸ���ϱ�

        //rigid.AddTorque(Vector3.back); // �ڷ� ȸ�� // AddTorque(Vec) : Vec ������ ������ ȸ������ ����.
        //rigid.AddTorque(Vector3.up); // ���ڸ����� �������� ȸ�� // Vec�� ������ ��� ������ �̵� ���⿡ ����!
        rigid.AddTorque(Vector3.down); // ���ڸ����� ���������� ȸ��
    }
}
