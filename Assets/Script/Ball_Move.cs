﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{

    Vector3 X = new Vector3(1, 0, 0);
    Vector3 Y = new Vector3(0, 1, 0);
    Vector3 Z = new Vector3(0, 0, 1);

    

    public float speed = 2f;

    Vector3 target;      // 入力受付時、移動後の位置を算出して保存 
    Vector3 prevPos;     // 何らかの理由で移動できなかった場合、元の位置に戻すため移動前の位置を保存
    Rigidbody player_Rigidbody;

    Animator animator;   // アニメーション

    private bool jump_Mode;

    public Down_Collision down;

    void Start()
    {
        target = transform.position;
        animator = GetComponent<Animator>();
        player_Rigidbody = GetComponent<Rigidbody>();
        jump_Mode = false;
    }

    void Update()
    {

        //移動中かどうかの判定。移動中でなければ入力を受付
        if (transform.position == target)
        {
            //落下判定
            if (down.down_exist == false)
            {
                target = target - Y;
            }
            SetTargetPosition();
        }
        Move();

        //xでジャンプモード
        if (Input.GetKeyDown("x"))
        {
            jump_Mode = !(jump_Mode);
        }
    }

    //入力に応じて移動後の位置を算出
    void SetTargetPosition()
    {

        prevPos = target;

        //ジャンプモードでないとき
        if (!jump_Mode)
        {
            if (Input.GetKeyDown("right"))
            {
                target = transform.position + X;
                SetAnimationParam(1);
                return;
            }
            if (Input.GetKeyDown("left"))
            {
                target = transform.position - X;
                SetAnimationParam(2);
                return;
            }
            if (Input.GetKeyDown("up"))
            {
                target = transform.position + Z;
                SetAnimationParam(3);
                return;
            }
            if (Input.GetKeyDown("down"))
            {
                target = transform.position - Z;
                SetAnimationParam(0);
                return;
            }
        }
        //ジャンプモードのとき
        else if (jump_Mode)
        {
            if (Input.GetKeyDown("right"))
            {
                target = transform.position + X + Y;
                SetAnimationParam(1);
                return;
            }
            if (Input.GetKeyDown("left"))
            {
                target = transform.position - X + Y;
                SetAnimationParam(2);
                return;
            }
            if (Input.GetKeyDown("up"))
            {
                target = transform.position + Z + Y;
                SetAnimationParam(3);
                return;
            }
            if (Input.GetKeyDown("down"))
            {
                target = transform.position - Z + Y;
                SetAnimationParam(0);
                return;
            }

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

    //ジャンプモード
    void Jump()
    {

    }

}