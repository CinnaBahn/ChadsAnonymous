using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMissles : MonoBehaviour
{
	public int maxTime = 0;
	public AnimationCurve rateCurve;

	public float second = 0f;
	public int elapsed = 0;
	void Update()
	{
		second += Time.deltaTime;
		if(second > 1f)
		{
			if (elapsed < maxTime)
			{
				elapsed++;
			}
			if(Random.Range(0.0f, 1.0f) < (rateCurve.Evaluate(elapsed / 120.0f) + 0.1f))
			{
				transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
				
			}
			second = 0f;
		}
	}
}
