using UnityEngine;

public class TransformObjects : MonoBehaviour
{
    public GameObject cube, sphere, plane;

    void Update()
    {
        // **1. Position Transformation (Move in different directions at different speeds)**
        if (Input.GetKey(KeyCode.W)) cube.transform.position += new Vector3(0, 0, 0.05f);  // Forward
        if (Input.GetKey(KeyCode.S)) cube.transform.position -= new Vector3(0, 0, 0.05f);  // Backward

        if (Input.GetKey(KeyCode.A)) plane.transform.position -= new Vector3(0.05f, 0, 0); // Left
        if (Input.GetKey(KeyCode.D)) plane.transform.position += new Vector3(0.05f, 0, 0); // Right

        if (Input.GetKey(KeyCode.UpArrow)) sphere.transform.position += new Vector3(0, 0.05f, 0);  // Move Up
        if (Input.GetKey(KeyCode.DownArrow)) sphere.transform.position -= new Vector3(0, 0.05f, 0); // Move Down

        // **2. Rotation Transformation (Rotate along different axes)**
        if (Input.GetKey(KeyCode.R)) cube.transform.Rotate(1, 0, 0); // Cube rotates along X-axis
        if (Input.GetKey(KeyCode.T)) plane.transform.Rotate(0, 1, 0); // Sphere rotates along Y-axis
        if (Input.GetKey(KeyCode.Y)) sphere.transform.Rotate(0, 0, 1); // Plane rotates along Z-axis

        // **3. Scaling Transformation (Scale in different directions)**
        if (Input.GetKey(KeyCode.Z)) cube.transform.localScale += new Vector3(-0.05f, 0, 0);  // Scale Cube in X direction
        if (Input.GetKey(KeyCode.X)) sphere.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f); // Scale Sphere in Y direction
        if (Input.GetKey(KeyCode.C)) plane.transform.localScale += new Vector3(0, 0, 0.05f);  // Scale Plane in Z direction
    }
}
