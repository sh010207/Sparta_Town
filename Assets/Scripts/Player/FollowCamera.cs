using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class FollowCamera : MonoBehaviour
{
    Transform target; 


    public void Start()
    {
        //target = ReSpawn. .transform;
    }

    private void Update()
    {
        if (target == null)
        {
            return;
        }
        Vector3 targetPos = target.position;
        targetPos.z = -10;
        transform.position = Vector3.Lerp(transform.position, targetPos, 2f * Time.deltaTime);

        //transform.position = Vector2.Lerp(transform.position, target.position, 2f * Time.deltaTime);
        //transform.Translate(0, 0, -10);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
