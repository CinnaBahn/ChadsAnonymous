using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMissle : MonoBehaviour
{
	Rigidbody2D r;
	void Start()
	{
		r = gameObject.GetComponent<Rigidbody2D>();
		r.AddForce(transform.up * Random.Range(125f, 175f));
		r.AddForce(transform.right * Random.Range(-150f, 150f));
	}

	void Update()
	{
    	Vector3 v = Vector3.zero - transform.position;
    	r.AddForce(v.normalized * 100f * Time.deltaTime);
	}
}
