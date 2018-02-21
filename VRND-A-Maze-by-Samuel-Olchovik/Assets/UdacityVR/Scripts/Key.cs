using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public Door door;
	public GameObject key;

	bool keyCollected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.position = transform.position + new Vector3 (0, 0.02f * Mathf.Sin (Time.time * 5.0f), 0);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.identity);
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
		door.Unlock();

        // Set the Key Collected Variable to true
		keyCollected = true;

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(key);
    }
}
