using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    public float rotationSpeed = 0.1f; // Adjust this value to change the rotation speed

    private void Update()
    {
        RotateSkyboxTexture();
    }

    private void RotateSkyboxTexture()
    {
        // Get the current rotation of the skybox
        Vector2 skyboxUVOffset = RenderSettings.skybox.GetVector("_Rotation");

        // Rotate the skybox by the specified speed
        skyboxUVOffset.x += rotationSpeed * Time.deltaTime;

        // Update the skybox rotation
        RenderSettings.skybox.SetVector("_Rotation", skyboxUVOffset);
    }
}