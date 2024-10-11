using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayerAnimationController : AnimationController
{
    // ÀÏ´Ü °È±â¸¸.
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int isJump = Animator.StringToHash("isJump");
    //
    private readonly float magnituteThreshold = 0.5f;


    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        if(gameController)
            gameController.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(isWalking, obj.magnitude >  magnituteThreshold);
    }
    
    private void Update()
    {
    }
}

