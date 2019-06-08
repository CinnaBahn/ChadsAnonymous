using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomLocationMissile : MonoBehaviour
{
	GameObject sprite;
	float offset = 1.5f;
	void Start()
	{
		transform.eulerAngles = new Vector3(0, 0, Random.Range(0f, 360f));
		sprite = gameObject.transform.GetChild(0).gameObject;
		
	}
}
