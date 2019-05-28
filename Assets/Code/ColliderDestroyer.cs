using UnityEngine;

public class ColliderDestroyer : MonoBehaviour
{
	public LayerMask DestroyLayers;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if ((DestroyLayers.value & 1 << collision.gameObject.layer) != 0)
			GameObject.Destroy(collision.gameObject);
	}
}