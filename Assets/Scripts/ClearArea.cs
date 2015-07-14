using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;

		if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f) {
			SendMessageUpwards ("OnFindClearArea");
		}
	}

	void OnTriggerStay () {
		timeSinceLastTrigger = 0f;
	}
}
