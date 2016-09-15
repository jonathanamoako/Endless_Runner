using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {

    public GameObject leftTilePrefab;
    public GameObject currentTile;

	// Use this for initialization
	void Start ()
    {
	for (int i = 0; i < 10; i++)
        {
            SpawnTiles();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SpawnTiles ()
    {
        Instantiate(leftTilePrefab, currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
    }
}
