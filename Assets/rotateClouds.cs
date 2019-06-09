using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateClouds : MonoBehaviour
{
	float speed;
    void Start()
    {
		speed = Random.Range(0.5f, 5f);
    }
    void Update()
    {
		transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
