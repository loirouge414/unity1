using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update\

    int hp = 100;   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            hp -= 20;
            if (hp <= 0)
                print("���� ����!");
            else
                Debug.Log("���� ü���� " + hp + "�Դϴ�!");
        }
    }
}
//���콺 ��ư : Input.GetMouseButtonDown();             - ���� ��
//              Input.GetMouseButtonUp();               - �� ��
//              Input.GetMouseButton(0 or 1);           - ������ ���� �� ���ȸ� / 0 - ��Ŭ��, 1 - ��Ŭ��

//Ű���� ���� : Input.GetKeyDown(*,*);                  - ���� ��
//              Input.GetKeyUp(*,*);                    - �� ��
//              Input.GetKey(*,*);                      - ������ �ִ� ����