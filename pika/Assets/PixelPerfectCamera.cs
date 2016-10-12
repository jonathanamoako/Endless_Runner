using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {
    private int direction;
    [SerializeField]
    private int resolutionY;
    
    private float scale;
    private float PixelPerUnits = 1;

    Camera camera;
    void Start () {
        camera = Camera.main.GetComponent<Camera>();

        direction = Screen.height;
        scale = direction / resolutionY;
        PixelPerUnits *= scale;

        camera.orthographicSize = (direction / 2f) / PixelPerUnits;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
