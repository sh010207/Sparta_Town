using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static string CurrentTime()
    {
        return DateTime.Now.ToString(("HH : mm"));
    }
}
