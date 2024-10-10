using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private GameObject objectToThrow;
    public GameObject player;

    private void Start()
    {
        
    }
    void Update()
    {
        transform.position = player.transform.position;
    }
}
