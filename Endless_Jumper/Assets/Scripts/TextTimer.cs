using UnityEngine;
using System.Collections;

public class TextTimer : MonoBehaviour
{
    [SerializeField]
    private float time = 2f; //Seconds to read the text

    void Start()
    {
        Destroy(gameObject, time);
    }

}

