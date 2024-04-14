using UnityEngine;

public class DirectionalLightRotator : MonoBehaviour
{
    public float yRotationSpeed = 10f; // Adjustable Y-axis rotation speed
    public float zRotationSpeed = 10f; // Adjustable Z-axis rotation speed

    private void Update()
    {
        // Rotate the Directional Light around the Y-axis and Z-axis
        transform.Rotate(Vector3.up * yRotationSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward * zRotationSpeed * Time.deltaTime, Space.Self);
    }
}