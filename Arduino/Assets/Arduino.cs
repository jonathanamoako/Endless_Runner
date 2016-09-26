using UnityEngine;
using System.Collections;
using System.IO.Ports;



public class Arduino : MonoBehaviour {
   

	// Use this for initialization
	void Start () {
        stream = new SerialPort("COM4", 9600);
        stream.ReadTimeout = 50;
        stream.Open();


    }

    // Update is called once per frame
    void Update () {
	
	}
}
