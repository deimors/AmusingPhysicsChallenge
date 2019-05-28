using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffectorMagnitudeInverter : MonoBehaviour
{
	public PointEffector2D Effector;

	void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
			Effector.forceMagnitude *= -1;
	}
}
