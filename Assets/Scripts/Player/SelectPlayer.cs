using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public Players players;
    public SpriteRenderer spriteRenderer;
    public SelectPlayer[] selectPlayers; 
    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (GameManager.instance.currentPlayer == players) OnSelect();
        else OnDeSelect();

    }

    private void OnDeSelect()
    {
        spriteRenderer.color = new Color(0.5f, 0.5f, 0.5f);

    }

    private void OnSelect()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f);

    }

    private void OnMouseUpAsButton()
    {
        GameManager.instance.currentPlayer = players;
    }
}
