using UnityEngine;
using System.Collections;

public class HurtAndDie : MonoBehaviour {
	public GameObject zombie; 
	public GameObject Player;
	public Collider2D coll;

	// Use this for initialization
	void Start () {
	
	}


	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "zombie")
			Application.LoadLevel("Game Run"); //name of your death scene
		}
	}
