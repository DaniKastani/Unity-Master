using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
	[SerializeField] private BillboardType billboardType;

	public enum BillboardType {LookAtCamera, CameraForward};

	void LateUpdate(){
		switch (billboardType)
		{
			case BillboardType.LookAtCamera:
				transform.LookAt(Camera.main.transform.position, Vector3.up);
				break;
			case BillboardType.CameraForward:

				break;
			default:
				break;
		}
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

