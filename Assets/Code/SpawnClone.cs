using UnityEngine;

public class SpawnClone : MonoBehaviour
{
    public GameObject prefabToClone;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SpawnCloneObject();
        }
    }

    private void SpawnCloneObject()
    {
        if (prefabToClone != null)
        {
            GameObject clone = Instantiate(prefabToClone, transform.position, Quaternion.identity);
        }
    }
}