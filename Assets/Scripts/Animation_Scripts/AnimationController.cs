using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected GameController gameController;

    protected virtual void  Awake()
    {
        animator = GetComponentInChildren<Animator>();
        gameController = GetComponent<GameController>();
    }
}