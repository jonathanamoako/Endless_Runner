using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    [SerializeField]
    private float timerTime;

    void Start()
    {
        StartCoroutine(RunTime());
    }

	IEnumerator RunTime()
    {
        float timer = 0;
            
            while ( timer <timerTime)
        {
            timer += Time.deltaTime;
            print(timer);
            yield return null;
        }
        print("Timer Klaar");
    }
}
