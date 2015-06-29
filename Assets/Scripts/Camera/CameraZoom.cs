using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	
	public float zoomSpeed = 100.0f;

	private Vector3 moveDirection;

	void Start(){
		this.moveDirection = Vector3.zero;
	}

	void Update(){
		moveDirection = Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

		if(Input.GetAxis("Mouse ScrollWheel") != 0){
			transform.Translate(moveDirection, Space.Self);
		}
	}
}