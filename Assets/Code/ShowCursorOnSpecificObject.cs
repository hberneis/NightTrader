using UnityEngine;

public class TaggedCursorVisibility : MonoBehaviour
{
    public float maxDistance = 5f;
    public GameObject MailCam;
    public GameObject LapCam;
    public GameObject TradeCam;
    public GameObject DeliveryCam;
    public GameObject RaHomeCam;
    public GameObject RaMyPortfolioCam;

    public string targetTag = "Interactable";
    public string menuTag = "MoniterMenu";
    public string mailTag = "Mail";
    public string tradeTag = "Trade";
    public string deliveryTag = "Delivery";
    public string burgerTag = "Burger";
    public string bananaTag = "Banana";
    public string coffeeTag = "Coffee";
    public string sushiTag = "Sushi";
    public string donutTag = "Donut";
    public string sandwichTag = "Sandwich";
    public string raHomeTag = "RaHome";
    public string raMarketsTag = "RaMarkets";
    public string raMyPortfolioTag = "RaMyPortfolio";

    public SpawnFood spawnFood;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, maxDistance))
        {
            if (hit.transform.CompareTag(targetTag))
            {
                Cursor.visible = true;
            }
            else if (hit.transform.CompareTag(menuTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    LapCam.SetActive(true);
                    MailCam.SetActive(false);
                    TradeCam.SetActive(false);
                    DeliveryCam.SetActive(false);
                    RaHomeCam.SetActive(false);
                    RaMyPortfolioCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(mailTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    MailCam.SetActive(true);
                    LapCam.SetActive(false);
                    TradeCam.SetActive(false);
                    DeliveryCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(tradeTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    TradeCam.SetActive(true);
                    LapCam.SetActive(false);
                    MailCam.SetActive(false);
                    DeliveryCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(deliveryTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    DeliveryCam.SetActive(true);
                    TradeCam.SetActive(false);
                    LapCam.SetActive(false);
                    MailCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(raHomeTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    TradeCam.SetActive(false);
                    RaHomeCam.SetActive(true);
                    RaMyPortfolioCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(raMarketsTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    TradeCam.SetActive(true);
                    RaHomeCam.SetActive(false);
                    RaMyPortfolioCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(raMyPortfolioTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    TradeCam.SetActive(false);
                    RaHomeCam.SetActive(false);
                    RaMyPortfolioCam.SetActive(true);
                }
            }
            else if (hit.transform.CompareTag(burgerTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    //GetComponent<SpawnFood>().SpawnBurger();
                    spawnFood.SpawnBurger();
                }
            }
            else if (hit.transform.CompareTag(bananaTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    //GetComponent<SpawnFood>().SpawnBanana();
                    spawnFood.SpawnBanana();
                }
            }
            else if (hit.transform.CompareTag(coffeeTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    //GetComponent<SpawnFood>().SpawnCoffee();
                    spawnFood.SpawnCoffee();
                }
            }
            else if (hit.transform.CompareTag(sushiTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    //GetComponent<SpawnFood>().SpawnSushi();
                    spawnFood.SpawnSushi();
                }
            }
            else if (hit.transform.CompareTag(donutTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    //GetComponent<SpawnFood>().SpawnDonut();
                    spawnFood.SpawnDonut();
                }
            }
            else if (hit.transform.CompareTag(sandwichTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    //GetComponent<SpawnFood>().SpawnSandwich();
                    spawnFood.SpawnSandwich();
                }
            }
            else
            {
                Cursor.visible = false;
            }
        }
        else
        {
            Cursor.visible = false;
        }
    }
}