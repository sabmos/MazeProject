using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public float doorHeight = 10.0f;
	public AudioClip[] soundClips;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	bool locked = true;
	bool opening = false;

	AudioSource doorAudioSource;

	void Start () {
		doorAudioSource = GetComponent<AudioSource>();
	}

    void Update() {
		// If the door is opening and it is not fully raised
		// Animate the door raising up
		if (opening && transform.position.y < doorHeight) {
			transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
		}
	}

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
		if (!locked) {
			opening = true;
			doorAudioSource.clip = soundClips [1];
			doorAudioSource.Play ();
			}
        // (optionally) Else
            // Play a sound to indicate the door is locked
		else {
			doorAudioSource.clip = soundClips [0];
			doorAudioSource.Play ();
		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
