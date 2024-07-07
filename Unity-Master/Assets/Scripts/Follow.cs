using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Follow : MonoBehaviour
{
	[SerializeField] private Transform lookAt;
	[SerializeField] private Transform transformToFollow;
	[SerializeField] private float followSpeed;

	private Transform _thisTransform;

	void Start(){
		_thisTransform = transform;
	}

	private void Update(){

	_thisTransform.LookAt(lookAt, Vector3.up);
	_thisTransform.Rotate(0f, 180f, 0f);
	var newPosition = _thisTransform.position;
	var followPosition = transformToFollow.position;
	newPosition.x = Mathf.Lerp(newPosition.x, followPosition.x, followSpeed * Time.deltaTime);
	newPosition.y = Mathf.Lerp(newPosition.y, followPosition.y, followSpeed * Time.deltaTime);
	newPosition.z = Mathf.Lerp(newPosition.z, followPosition.z, followSpeed * Time.deltaTime);
	transform.position = newPosition;
	}

	
}




    /*public Transform MyCameraTransform;
	private Transform MyTransform;
	public bool alignNotLook = true;

	// Use this for initialization
	void Start () {
		MyTransform = this.transform;
		MyCameraTransform = Camera.main.transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (alignNotLook)
			MyTransform.forward = MyCameraTransform.forward;
		else
			MyTransform.LookAt (MyCameraTransform, Vector3.up);
	}
	}*/

