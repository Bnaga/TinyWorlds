using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedestrianSpawner : MonoBehaviour {


	public GameObject ped;
	public float spawnRate;
	private float spawnTimer;
	private List <pedestrianSpawner> destinations = new List <pedestrianSpawner>();
	public List <GameObject> spawned = new List<GameObject>();

	// Use this for initialization
	void Start () {
		pedestrianSpawner[] dest = FindObjectsOfType<pedestrianSpawner>();
		foreach (pedestrianSpawner d in dest){
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
		GameObject spawn = Instantiate(ped,transform.position,transform.rotation);
		Vector2 destination = destinations[Random.Range(0,destinations.Count)].transform.position;
		spawn.GetComponent<pedestrian>().Init(destination, this);
		spawned.Add(spawn);
	}

}
