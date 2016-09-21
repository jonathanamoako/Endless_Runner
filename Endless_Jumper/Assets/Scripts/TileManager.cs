using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {

    public GameObject leftTilePrefab;
    public GameObject topTilePrefab;
    public GameObject[] tilePrefabs;
    public GameObject currentTile;

    private static TileManager instance;

    public static TileManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManager>();
            }
            return instance;
        }
    }


    // Use this for initialization
    void Start ()
    {
	for (int i = 0; i < 10; i++)
        {
            SpawnTiles();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void SpawnTiles ()
    {
        int randomIndex = Random.Range(0, 2);

      currentTile = (GameObject) Instantiate(tilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position, Quaternion.identity);
    }
}
