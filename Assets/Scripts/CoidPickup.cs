using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoidPickup : MonoBehaviour
{
	[SerializeField] AudioClip coidPickupSFX;
	[SerializeField] int pointsForPickup = 100;

	bool wasCollected = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && !wasCollected)
        {
        	wasCollected = true;
        	FindObjectOfType<GameSession>().AddToScore(pointsForPickup);
        	AudioSource.PlayClipAtPoint(coidPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }

}
