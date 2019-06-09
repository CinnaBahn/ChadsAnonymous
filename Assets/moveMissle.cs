using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMissle : MonoBehaviour
{
	Rigidbody2D r;
	void Start()
	{
		r = gameObject.GetComponent<Rigidbody2D>();
		r.AddForce(transform.up * 150f);
		r.AddForce(transform.right * 150f);
	}

	void Update()
	{
    	Vector3 v = Vector3.zero - transform.position;
    	r.AddForce(v.normalized * 100f * Time.deltaTime);

		if(Vector3.Distance(Vector3.zero, transform.position) < 1.5f)
		{
			
			Destroy(gameObject);
		}
	}
}
