using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMissile : MonoBehaviour
{
    Vector3 last;
	void Update ()
	{
		transform.eulerAngles = new Vector3(0f, 0f, Quaternion.LookRotation(last - transform.parent.transform.position).z * 360f);
	}
}
