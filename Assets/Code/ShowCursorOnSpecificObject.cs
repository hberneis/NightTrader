using UnityEngine;

public class TaggedCursorVisibility : MonoBehaviour
{
    public float maxDistance = 5f;
    public GameObject MailCam;
    public GameObject LapCam;
    public GameObject TradeCam;
    public string targetTag = "Interactable";
    public string menuTag = "MoniterMenu";
    public string mailTag = "Mail";
    public string tradeTag = "Trade";

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
                }
            }
            else if (hit.transform.CompareTag(mailTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    MailCam.SetActive(true);
                    LapCam.SetActive(false);
                }
            }
            else if (hit.transform.CompareTag(tradeTag))
            {
                Cursor.visible = true;
                if (Input.GetMouseButtonDown(0))
                {
                    TradeCam.SetActive(true);
                    LapCam.SetActive(false);
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