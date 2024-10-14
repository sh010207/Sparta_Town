using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Timer_UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayTime;

    private IEnumerator Start()
    {
        while (true)
        {
            displayTime.text = Timer.CurrentTime();
            yield return new WaitForSeconds(1f);
        }
    }
}
