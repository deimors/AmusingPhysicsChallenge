using UnityEngine;

public class MouseFollower : MonoBehaviour
{
	public Transform Target;
	public Camera Camera;

	void Update()
	{
		Target.position = Camera.ScreenToWorldPoint(Input.mousePosition);
	}
}
