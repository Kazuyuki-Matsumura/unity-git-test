using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{

    Vector3 X = new Vector3(1, 0, 0);
    Vector3 Z = new Vector3(0, 0, 1);

    public float speed = 2f;
    Vector3 target;      // 入力受付時、移動後の位置を算出して保存 
    Vector3 prevPos;     // 何らかの理由で移動できなかった場合、元の位置に戻すため移動前の位置を保存

    Animator animator;   // アニメーション

    void Start()
    {
        target = transform.position;
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        //移動中かどうかの判定。移動中でなければ入力を受付
        if (transform.position == target)
        {
            SetTargetPosition();
        }
        Move();
    }

    //入力に応じて移動後の位置を算出
    void SetTargetPosition()
    {

        prevPos = target;

        if (Input.GetKey("right"))
        {
            target = transform.position + X;
            SetAnimationParam(1);
            return;
        }
        if (Input.GetKey("left"))
        {
            target = transform.position - X;
            SetAnimationParam(2);
            return;
        }
        if (Input.GetKey("up"))
        {
            target = transform.position + Z;
            SetAnimationParam(3);
            return;
        }
        if (Input.GetKey("down"))
        {
            target = transform.position - Z;
            SetAnimationParam(0);
            return;
        }
    }

    // WalkParam  0;下移動　1;右移動　2:左移動　3:上移動
    void SetAnimationParam(int param)
    {
        animator.SetInteger("WalkParam", param);
    }

    //目的地へ移動する
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}