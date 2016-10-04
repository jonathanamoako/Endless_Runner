using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public Transform canvas;
    public Transform canvas2;
    void Start ()
    {
        canvas.gameObject.SetActive(false);
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            
        }
	
	}
}
