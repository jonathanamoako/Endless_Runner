using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    private IEnumerator hello;

    void Start()
    {
      
        print("Srating " + Time.time);
        hello = WaitForPrint(2.0f);
        StartCoroutine(hello);

        print("Before WaitAndPrint Finishes " + Time.time);
      }

    private IEnumerator WaitForPrint(float waitTime)
    {
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
        }
   
    }
}
