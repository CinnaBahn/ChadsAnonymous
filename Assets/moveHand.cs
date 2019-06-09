using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHand : MonoBehaviour
{

	public bool right;

	void Update()
	{
			if(!right)
			{
				float trans = Input.GetAxis("Vertical");
				if (Input.GetAxis("Horizontal") < 0f)
				{
					transform.eulerAngles = new Vector3(0, 0, -trans * 90);
				}
				else
				{
					transform.eulerAngles = Vector3.zero;
				}
			}
			else
			{
				float trans = Input.GetAxis("Vertical2");
				if (Input.GetAxis("Horizontal2") > 0f)
				{
					transform.eulerAngles = new Vector3(0, 0, trans * 90);
				}

			}
	}
}
