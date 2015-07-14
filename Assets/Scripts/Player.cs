using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Helicopter helicopter;
	public Transform playerSpawnPoints; // The parent of the spawn points

	public AudioClip whatHappened;

	private bool reSpawn = false;
	private Transform[] spawnPoints;
	private bool lastToggle = false;
	private AudioSource innerVoice;

	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		foreach (AudioSource audioSource in audioSources) {
			if (audioSource.priority == 1) {
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = whatHappened;
		innerVoice.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != reSpawn) {
			Respawn ();
			reSpawn = false;
		} else {
			lastToggle = reSpawn;
		}
	}

	private void Respawn() {
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}

	void OnFindClearArea () {
		Debug.Log ("Found clear area in player");
		helicopter.Call ();
		// Deploy flare
		// Start spawning zombies
	}

}
