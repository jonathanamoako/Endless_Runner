using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

    private float fallDealy = 0.5f;

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
            StartCoroutine(FallDown());
            Debug.Log("Spawn Tile");
        }

    }
IEnumerator FallDown()
    {
        yield return new WaitForSeconds(fallDealy);
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
