using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;
	public UITextUpdate UIText_Coin;

	public GameObject coin;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate(coinPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f));
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (coin);

		// Run the cointUpdateText method in the UITextUpdate class
		UIText_Coin.addCoin ();
    }
}
