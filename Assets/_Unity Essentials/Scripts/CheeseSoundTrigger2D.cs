using UnityEngine;

public class CheeseSoundTrigger2D : MonoBehaviour
{

    AudioSource source; // AudioSource component to play sound
    Collider2D soundTrigger; // Collider to detect when the player enters the trigger area
    public bool alreadyPlayed = false; // Flag to check if the sound has already been played
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        source = GetComponent<AudioSource>(); // Get the AudioSource component attached to this GameObject
        soundTrigger = GetComponent<Collider2D>(); // Get the Collider component attached to this GameObject
    }
   
   private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Mouse_Player")) // Check if the object entering the trigger is tagged as "Mouse_Player" and sound hasn't been played yet
        {
            if (!alreadyPlayed) // Check if the sound has not been played yet
            {
                source.Play(); // Play the sound
                alreadyPlayed = true; // Set the flag to true to prevent sound from playing again
            }
            
        }
   }

}
