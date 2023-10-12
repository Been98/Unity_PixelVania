using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickup : MonoBehaviour
{
    [SerializeField] AudioClip LifePickupSFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameSession>().AddToLife();
            AudioSource.PlayClipAtPoint(LifePickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
