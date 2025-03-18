using UnityEngine;

public class VehicleMotion : MonoBehaviour
{
    public float speed = 2f;  // Adjust speed as needed

    void Update()
    {
        // Move the vehicle forward based on time scale
        transform.Translate(Vector3.forward * speed * Time.deltaTime * Time.timeScale);
    }
}

using UnityEngine;

public class BusRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Adjust speed as needed

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
