using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class FollowMouse2D : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed = 1f;

  void Update()
  {
		Vector3 temp = Input.mousePosition;
		temp.z = 10f; // Set this to be the distance you want the object to be placed in front of the camera.
		this.transform.position = Camera.main.ScreenToWorldPoint(temp);
  }
}
