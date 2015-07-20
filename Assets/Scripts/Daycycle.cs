using UnityEngine;
using System.Collections;

public class Daycycle : MonoBehaviour {

	[Tooltip ("Number of minutes per second that pass, try 60")]
	public float minutesPerSecond;
	
	// Update is called once per frame
	void Update () {
		float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
		transform.RotateAround (transform.position, Vector3.forward, angleThisFrame);
	}
}
