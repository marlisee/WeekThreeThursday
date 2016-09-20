using UnityEngine;

public class SpawnZombie : MonoBehaviour {

public GameObject zombie;                // The prefab to be spawned. 
public GameObject bullet; 
public GameObject spawnZombie;
//public float spawnTime = 4f;            // How long between each spawn.
private Vector2 spawnPosition;
public float maxTime = 6;
public float minTime = 2;
private float time;
private float spawnTime;


void Start () 
{
	// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
//	InvokeRepeating ("Spawn", spawnTime, spawnTime);
	
	SetRandomTime();
	time = minTime;
}

void Update () {

		//Counts up
		time += Time.deltaTime;

		//Check if its the right time to spawn the object
		if (time >= spawnTime) {
			Spawn();
			SetRandomTime ();

		}
	}


void Spawn ()
{
		time = minTime;
		spawnPosition.x = Random.Range (-10, 10);
		spawnPosition.y = Random.Range (-10, 10);
	
		Vector2 position = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
		Instantiate(zombie, position, Quaternion.identity);
}


void  OnTriggerEnter(Collider bullet)
{
	if (bullet.gameObject.tag == "bullet") 
	{
		DestroyObject(zombie.gameObject);
			DestroyObject (bullet.gameObject);
	}
}

void SetRandomTime(){
	spawnTime = Random.Range(minTime, maxTime);
}


}
	


//{
//	public GameObject zombie;                // The enemy prefab to be spawned.
//	public float spawnTime = 3f;            // How long between each spawn.
//	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
//
//
//	void Start ()
//	{
//		InvokeRepeating ("Spawn", spawnTime, spawnTime);
//	}
//
//
//
//	void Spawn ()
//	{
//		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
//
//
//		Instantiate (zombie, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
//
//	GameObject temp = Instantiate (zombie, transform.position, transform.rotation) as GameObject;
//	}
//		
//
//
