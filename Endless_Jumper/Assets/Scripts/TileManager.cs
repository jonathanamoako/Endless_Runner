﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TileManager : MonoBehaviour {

    public GameObject leftTilePrefab;
    public GameObject topTilePrefab;
    public GameObject[] tilePrefabs;
    public GameObject currentTile;

    private static TileManager instance;
    private Stack<GameObject> leftTiles = new Stack<GameObject>();
    private Stack<GameObject> topTiles = new Stack<GameObject>();



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

        CreateTiles(20);

	for (int i = 0; i < 10; i++)
        {
            SpawnTiles();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void CreateTiles(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            leftTiles.Push(Instantiate(tilePrefabs[0]));
            topTiles.Push(Instantiate(tilePrefabs[1]));
            topTiles.Peek().SetActive(false);
            leftTiles.Peek().SetActive(false);

        }

        for (int i = 0; i < amount; i++)
        {

        }
    }

    public void SpawnTiles ()
    {

        if(leftTiles.Count == 0 || topTiles.Count == 0)
        {
            CreateTiles(10);
        }

        int randomIndex = Random.Range(0, 2);

        if (randomIndex == 0)
        {
            GameObject tmp = leftTiles.Pop();
            tmp.SetActive(true);
            tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
            currentTile = tmp;

        }
        else if(randomIndex == 1)
        {
            GameObject tmp = topTiles.Pop();
            tmp.SetActive(true);
            tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
            currentTile = tmp;
        }

      //currentTile = (GameObject) Instantiate(tilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position, Quaternion.identity);
    }
}
