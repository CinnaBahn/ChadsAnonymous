using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMissle : MonoBehaviour
{
	private Rigidbody2D r;
	void Start()
	{
		r = gameObject.GetComponent<Rigidbody2D>();
		r.AddForce(transform.up * Random.Range(400f, 700f));
		r.AddForce(transform.right * Random.Range(-250f, 250f));
	}

	void Update()
	{
		r.velocity = -transform.position;
	}
}
