using UnityEngine;
using System.Collections;
using System.IO.Ports;



public class Arduino : MonoBehaviour {
    SerialPort sp = new SerialPort("COM5", 9600);



    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        var str = sp.ReadLine(); 

        try
        {
            // print(sp.ReadLine());
            Debug.Log(str);
        }
        catch (System.Exception)
        {

        }

        //var str = sp.ReadLine();
       
      //  strArray : string[];
       // strArray = str.Split(",");




    } }
 


