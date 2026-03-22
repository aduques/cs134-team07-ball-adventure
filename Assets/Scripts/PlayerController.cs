using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Rigidbody of the player.
    private Rigidbody rb; 

    // Audio Source for when player picks up "PickUp" objects.
    private AudioSource pickUpSound;

    // Object for Pickup_VFX
    public GameObject pickupVFXPrefab;

    // Object for Win_VFX
    public GameObject winVFXPrefab;

    // Object for Loss_VFX
    public GameObject lossVFXPrefab;

    // Audio Source for when player wins
    private AudioSource winSound;

    // Variable to keep track of collected "PickUp" objects.
    private int count;

    // Movement along X and Y axes.
    private float movementX;
    private float movementY;

    // Speed at which the player moves.
    public float speed = 0;

    // UI text component to display count of "PickUp" objects collected.
    public TextMeshProUGUI countText;

    // UI object to display winning text.
    public TextMeshProUGUI winText;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the Rigidbody component attached to the player.
                rb = GetComponent<Rigidbody>();

        // Initialize count to zero.
                count = 0;

        // Update the count display.
                SetCountText();

        // Initially set the win text to be inactive.
                winText.gameObject.SetActive(false);
    }

    // Called when scene is loaded
    void Awake()
    {
        // When an object has multiple audio sources, they can be
        // stored as an array
        AudioSource[] audioSources = GetComponents<AudioSource>();
        pickUpSound = audioSources[0];
        winSound = audioSources[1];
    }
    
    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {
        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement.
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    // FixedUpdate is called once per fixed frame-rate frame.
    private void FixedUpdate() 
    {
        // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        // Apply force to the Rigidbody to move the player.
        rb.AddForce(movement * speed); 
    }

    
    void OnTriggerEnter(Collider other) 
    {
        // Check if the object the player collided with has the "PickUp" tag.
        if (other.gameObject.CompareTag("PickUp")) 
        {
            // Code from VFX Tutorial
            if (pickupVFXPrefab != null) {
                Instantiate(pickupVFXPrefab, transform.position, Quaternion.identity);
            }
            // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);

            // Increment the count of "PickUp" objects collected.
            count = count + 1;

            // Play the PickUp audio
            pickUpSound.Play();

            // Update the count display.
            SetCountText();
        }
    }

    // Function to update the displayed count of "PickUp" objects collected.
    void SetCountText() 
    {
        // Update the count text with the current count.
        countText.text = "Count: " + count.ToString();

        // Check if the count has reached or exceeded the win condition.
        if (count >= 12)
        {
            // Code from VFX Tutorial
            if (winVFXPrefab != null) {
                Instantiate(winVFXPrefab, transform.position, Quaternion.identity);
            }
            winText.gameObject.SetActive(true);
            winText.text = "You Win!";
            GameObject.Find("Pinball_Background").GetComponent<AudioSource>().Stop();
            winSound.Play();

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Code from VFX Tutorial
            if (lossVFXPrefab != null) {
                Instantiate(lossVFXPrefab, transform.position, Quaternion.identity);
            }
            GameObject.Find("Pinball_Background").GetComponent<AudioSource>().Stop();
            collision.gameObject.GetComponentInParent<AudioSource>().Play();
            winText.gameObject.SetActive(true);
            winText.text = "You Lose!";

            Destroy(gameObject);
        }

    }


}