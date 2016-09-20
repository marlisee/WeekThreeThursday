using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;

	public GameObject bulletSpawn;
	public GameObject bullet;
	public float bulletlife;
	public float bulletspeed;
	public float fireRate;
	private float nextFiretime;

	// Use this for initialization
	void Start () {
	}

	void Update () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		Rigidbody2D rigi = GetComponent<Rigidbody2D>();
		rigi.velocity = new Vector2 (movex * Speed, movey * Speed);

		Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		diff.Normalize();

		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
		if (Input.GetMouseButton(0))
		{
			if (Time.time > fireRate + nextFiretime) {
				GameObject temp = Instantiate (bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation) as GameObject;
				temp.transform.Rotate(temp.transform.localRotation.x,temp.transform.localRotation.y, temp.transform.localRotation.z+Random.Range(-15,15));
				temp.GetComponent<Rigidbody2D> ().AddForce (temp.transform.up* bulletspeed);
				nextFiretime = Time.time;
				Destroy (temp, bulletlife);

			}
		}
	}
}
