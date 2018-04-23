using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedestrian : MonoBehaviour {

	[SerializeField]
	private Vector2 destination;
	[SerializeField]
	private float movementSpeed;
	private Vector2 movement;
	
	private bool canMove;
	private int overlappingActors;
	private pedestrianSpawner origin;
	private float deathTimer;
	private Vector2 origPos;


	void Start(){
		canMove=true;
	}
	public void Init(Vector2 dest, pedestrianSpawner org){
		destination = dest;
		origin = org;
	}
	
	// Update is called once per frame
	void Update () {
		origPos = transform.position;
		if (canMove){			
			transform.position = Vector2.MoveTowards( transform.position, destination, movementSpeed * Time.deltaTime) ;
			Vector2 moveDirection = (Vector2)transform.position - origPos; 
			if (moveDirection != Vector2.zero) {
				float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
         	}
		}
		if (Vector2.Distance(transform.position,destination) < 2) Remove();
		Debug.DrawLine(transform.position,destination);
	}

	void Remove(){
		//origin.spawned.Remove(gameObject);
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider other){
		Debug.Log("HIT");
		if (other.tag == "line" || other.GetComponent<pedestrian>()){
			canMove = false;
			overlappingActors++;
		}
		if (other.tag == "vehicle"){
			overlappingActors += 100;
			Remove();
			

		}
	}
	void OnTriggerExit (Collider other){
		overlappingActors--;
		if (overlappingActors <= 0) canMove = true;
	}

	IEnumerator Death()
    {
        yield return new WaitForSeconds(5);
        Remove();
    }

}
