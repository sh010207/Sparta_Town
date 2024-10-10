using System;
using UnityEngine;

public class PlayerAimRotaion : MonoBehaviour 
{
    [SerializeField] private SpriteRenderer playerRederer;

    private GameController controller;

    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    private void Start()
    {
        // 마우스의 위치가 들어오는 OnLookEvenet에 등록
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 aimDrirection)
    {
        // OnLook
        RotateArm(aimDrirection);
    }

    private void RotateArm(Vector2 drirection)
    {
        float rotZ = Mathf.Atan2(drirection.y, drirection.x) * Mathf.Rad2Deg;
        
        //캐릭터 뒤집기
        playerRederer.flipX =  Mathf.Abs(rotZ) > 90f;
    }
}
