using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed = 0.5f; // by declaring this variable, we can set the speed of rotation in the inspector window of unity editor,
                                //  instead of coming to vs code every time we want to change the speed of rotation.
                                // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject onCollectEffect; // Effect to instantiate when the collectible is collected
    


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed); // Rotate the collectible object around the Z-axis
    }

    private void OnTriggerEnter(Collider other)
    {
        // Code to destroy the collectible when the player collides with it
        if (other.CompareTag("Mouse_Player")) // Check if the object colliding is tagged as "Mouse_Player"
        {
            Destroy(gameObject); // Destroy this collectible object

            // // Instantiate the collectible burst effect at the collectible's position and rotation
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
