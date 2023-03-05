using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int speed = 5;
    Vector3 movePosition;
    public Vector3 moveX = new Vector3(2.5f, 0, 0);
    public Vector3 moveY = new Vector3(0, 2.5f, 0);
    //移動中の判定
    bool isMove;

    void Start()
    {
        isMove = false;
        movePosition = this.transform.position;
    }

    void Update()
    {
        //移動中でないならば、矢印キーで移動
        if(isMove == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                movePosition = this.transform.position + moveY;
                isMove = true;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                movePosition = this.transform.position - moveY;
                isMove = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                movePosition = this.transform.position + moveX;
                isMove = true;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                movePosition = this.transform.position - moveX;
                isMove = true;
            }
        }

        //移動先まで直線的に移動
        this.transform.position = Vector3.MoveTowards(this.transform.position, movePosition, speed * Time.deltaTime);

        //指定先までオブジェクトが到達すると再度移動可能
        if(this.transform.position == movePosition)
        {
            isMove = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
