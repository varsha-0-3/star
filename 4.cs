using UnityEngine;

public class FPSPlayerController : MonoBehaviour
{
    public float speed = 5f; // Movement speed
    public float rotationSpeed = 100f; // Rotation speed

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Get the Character Controller
    }

    void Update()
    {
        // Get movement input (Forward/Backward & Left/Right)
        float moveZ = Input.GetAxis("Vertical");  // W & S for forward/backward
        float moveX = Input.GetAxis("Horizontal"); // A & D for left/right

        // Move the player based on input
        Vector3 move = transform.forward * moveZ + transform.right * moveX;
        controller.Move(move * speed * Time.deltaTime);

        // Rotate Left/Right using A & D
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
