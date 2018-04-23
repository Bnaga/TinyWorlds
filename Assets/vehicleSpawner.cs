using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicleSpawner : MonoBehaviour {


	public GameObject vehicle;
	public float spawnRate;
	private float spawnTimer;
	private List <vehicleSpawner> destinations = new List <vehicleSpawner>();
	public List <GameObject> spawned = new List<GameObject>();

	// Use this for initialization
	void Start () {
		vehicleSpawner[] dest = FindObjectsOfType<vehicleSpawner>();
		foreach (vehicleSpawner d in dest){
			if (d != this)
				destinations.Add(d);
		}
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		if (spawnTimer > spawnRate){
			spawnTimer=0;
			Spawn();
		}
		
	}

	void Spawn(){
		GameObject spawn = Instantiate(vehicle,transform.position,transform.rotation);
		Vector2 destination = destinations[Random.Range(0,destinations.Count)].transform.position;
		spawn.GetComponent<vehicle>().Init(destination);
		spawned.Add(spawn);
	}

}
