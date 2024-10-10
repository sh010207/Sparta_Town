using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameController controller;
    private Rigidbody2D movementRb;

    private Vector2 movementDir = Vector2.zero;

    private void Awake()
    {
        // 같은 게임오브젝트의 GameController, RigiBody가져온다.
        controller = GetComponent<GameController>();
        movementRb = GetComponent<Rigidbody2D>(); 
    }

    private void Start()
    {
        // OnMoveEvent에서 Move를 호출하라고 등록
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 물리 업데이트에서 움직임 적용
        ApplyMovement(movementDir);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRb.velocity = direction;    
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정함 실제로 움직임 x
        // 움직이는건 물리업데이트에서 진행된다.(rigibody가 물리이기 때문)
        movementDir = direction;    
    }
}