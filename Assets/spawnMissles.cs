using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMissles : MonoBehaviour
{
	public int maxTime = 0;
	public AnimationCurve rateCurve;
	public GameObject pre;

	float second = 0f;
	int elapsed = 10;
	void Update()
	{
		second += Time.deltaTime;
		if(second > 1f)
		{
			if (elapsed < maxTime)
			{
				elapsed++;
			}
			if(Random.Range(0.0f, 1.0f) < (rateCurve.Evaluate(elapsed / 120.0f) + 0.15f))
			{
				transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
                GameObject bruh = Instantiate(pre, transform.GetChild(0).transform.position, Quaternion.identity);
                bruh.SetActive(true);
                bruh.transform.eulerAngles = transform.GetChild(0).transform.eulerAngles;
			}
			second = 0f;
		}
	}
}
