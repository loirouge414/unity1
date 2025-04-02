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
                print("게임 오버!");
            else
                Debug.Log("현재 체력은 " + hp + "입니다!");
        }
    }
}
//마우스 버튼 : Input.GetMouseButtonDown();             - 누를 때
//              Input.GetMouseButtonUp();               - 뗄 때
//              Input.GetMouseButton(0 or 1);           - 누르고 있을 때 동안만 / 0 - 좌클릭, 1 - 우클릭

//키보드 감지 : Input.GetKeyDown(*,*);                  - 누를 때
//              Input.GetKeyUp(*,*);                    - 뗄 때
//              Input.GetKey(*,*);                      - 누르고 있는 동안