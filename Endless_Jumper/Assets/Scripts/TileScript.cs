using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

    public float fallDealy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            TileManager.Instance.SpawnTiles();
            Debug.Log("Spawn Tile");
        }

    }

}
