using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject burger;
    public GameObject banana;
    public GameObject coffee;
    public GameObject sushi;
    public GameObject donut;
    public GameObject sandwich;

    public SpawnPlate spawnPlate;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SpawnBanana();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SpawnBurger();
        }
    }

    public void SpawnBurger()
    {
        if (burger != null)
        {
            GameObject clone = Instantiate(burger, transform.position, Quaternion.identity);
            //GetComponent<SpawnPlate>().PlateSpawn();
            spawnPlate.PlateSpawn();
        }
    }
    public void SpawnBanana()
    {
        if (banana != null)
        {
            GameObject clone = Instantiate(banana, transform.position, Quaternion.identity);
        }
    }
    public void SpawnCoffee()
    {
        if (coffee != null)
        {
            GameObject clone = Instantiate(coffee, transform.position, Quaternion.identity);
        }
    }
    public void SpawnSushi()
    {
        if (sushi != null)
        {
            GameObject clone = Instantiate(sushi, transform.position, Quaternion.identity);
        }
    }
    public void SpawnDonut()
    {
        if (donut != null)
        {
            GameObject clone = Instantiate(donut, transform.position, Quaternion.identity);
        }
    }
    public void SpawnSandwich()
    {
        if (sandwich != null)
        {
            GameObject clone = Instantiate(sandwich, transform.position, Quaternion.identity);
        }
    }
}