using UnityEngine;

public class Raycast2D : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f; // Speed of rotation
    [SerializeField] private float rayDistance = 10f;

    private RaycastHit2D hit;

    void Update()
    {
        // Rotate the empty GameObject
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        // Cast a ray in the forward direction of the empty GameObject
        hit = Physics2D.Raycast(transform.position, transform.right, rayDistance);

        if (hit.collider != null)
        {
            float distanceToObject = hit.distance; // Capture the distance
            Debug.Log("Hit: " + hit.collider.name + " | Distance: " + distanceToObject);
        }
        else
        {
            Debug.Log("No hit detected.");
        }
    }

    // Draw Gizmos to visualize the ray in the Scene View
    private void OnDrawGizmos()
    {
        Gizmos.color = (hit.collider != null) ? Color.red : Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.right * rayDistance);

        if (hit.collider != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(hit.point, 0.2f);
        }
    }
}
