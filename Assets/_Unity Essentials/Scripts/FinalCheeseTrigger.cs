using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class FinalCheeseTrigger : MonoBehaviour
{
    public AudioSource victorySound; // Plays when player collects this cheese
    public Image youWinImage;        // UI Image that will appear

    private bool triggered = false;  // Prevent multiple triggers

    private void Start()
    {
        // Make sure the collider is set as trigger
        GetComponent<Collider>().isTrigger = true;

        // Hide the "You Win" image at start
        if (youWinImage != null)
        {
            youWinImage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.CompareTag("Mouse_Player"))
        {
            triggered = true;

            // Play victory sound
            if (victorySound != null)
            {
                victorySound.Play();
            }

            // Show & format the "You Win" image
            if (youWinImage != null)
            {
                RectTransform rt = youWinImage.rectTransform;
                rt.anchorMin = new Vector2(0.5f, 0.5f);
                rt.anchorMax = new Vector2(0.5f, 0.5f);
                rt.pivot = new Vector2(0.5f, 0.5f);
                rt.anchoredPosition = Vector2.zero;          // Center of screen
                rt.sizeDelta = new Vector2(800, 400);         // Make it large
                youWinImage.gameObject.SetActive(true);
            }

            // Destroy cheese after sound finishes (or short delay if no sound)
            float delay = (victorySound != null && victorySound.clip != null)
                          ? victorySound.clip.length
                          : 0.1f;
            Destroy(gameObject, delay);
        }
    }
}
