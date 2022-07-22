using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    [SerializeField] Number h0;
    [SerializeField] Number h1;
    [SerializeField] Number m0;
    [SerializeField] Number m1;
    [SerializeField] Number s0;
    [SerializeField] Number s1;

    [SerializeField] float delayTime = 1f;

    private string time;

    IEnumerator Start()
    {
        yield return StartCoroutine(WaitAndPrint(delayTime));
    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        time = DateTime.UtcNow.ToLocalTime().ToString("HH:mm:ss");

        h0.UpdateNumber(time.Substring(0, 1));
        h1.UpdateNumber(time.Substring(1, 1));
        m0.UpdateNumber(time.Substring(3, 1));
        m1.UpdateNumber(time.Substring(4, 1));
        s0.UpdateNumber(time.Substring(6, 1));
        s1.UpdateNumber(time.Substring(7, 1));

        yield return new WaitForSeconds(waitTime);
        yield return StartCoroutine(WaitAndPrint(delayTime));
    }


}
