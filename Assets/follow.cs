using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public GameObject left;
	public GameObject right;

	void Update() {

		Vector3 deltaPos = left.transform.position - right.transform.position;
		//transform.rotation = Quaternion.LookRotation(holdControl.transform.position - stringControl.transform.position, holdControl.transform.TransformDirection(Vector3.forward));

		Quaternion rot = Quaternion.LookRotation (deltaPos, left.transform.TransformDirection (Vector3.forward));

		transform.rotation = rot;
		transform.position = left.transform.position;

	}

}
