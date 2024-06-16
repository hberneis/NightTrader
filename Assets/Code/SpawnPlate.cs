using UnityEngine;

public class SpawnPlate : MonoBehaviour
{
    public GameObject plate;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //SpawnCloneObject();
        }
    }

    public void PlateSpawn()
    {
        if (plate != null)
        {
            GameObject clone = Instantiate(plate, transform.position, Quaternion.identity);
        }
    }
}