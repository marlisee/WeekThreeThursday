using UnityEngine;
using System.Collections;

public class destroyZombie : MonoBehaviour {
	public GameObject bullet; 
	public GameObject zombie; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D zombie)
		{
			if (bullet.gameObject.tag == "bullet"); 
			{
				Destroy(zombie.gameObject);
			Destroy (gameObject);
			}
		}


	}

