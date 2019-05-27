using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallBouncer : MonoBehaviour
{
	public Rigidbody2D RigidBody;

	public float MinForce = 1000;
	public float MaxForce = 10000;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.contactCount == 0)
			return;

		var firstPoint = col.contacts.First().point;

		var dir = ((Vector2) transform.position - firstPoint).normalized;

		var force = Random.Range(MinForce, MaxForce);

		RigidBody.AddForce(dir * force);
	}
}
