using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StockScript : MonoBehaviour
{
    //Original Stock Prices
    public double MMUPrice = 9.03;
    public double MLTPrice = 459.81;
    public double RCIPrice = 1132.26;
    public double TOGPrice = 92955.03;
    public double CCCPrice = 460432.32;
    public string MMUPriceString;
    public string MLTPriceString;
    public string RCIPriceString;
    public string TOGPriceString;
    public string CCCPriceString;

    public TMP_Text MMUPriceTXT;
    public TMP_Text MLTPriceTXT;
    public TMP_Text RCIPriceTXT;
    public TMP_Text TOGPriceTXT;
    public TMP_Text CCCPriceTXT;

    public DateTime currentTime;
    private TimeController timeController;
    public int currentTimeInt;

    void Start()
    {
        timeController = GameObject.Find("timeController").GetComponent<TimeController>();
        // Convert double to string
        MMUPriceString = MMUPrice.ToString();
        MLTPriceString = MLTPrice.ToString();
        RCIPriceString = RCIPrice.ToString();
        TOGPriceString = TOGPrice.ToString();
        CCCPriceString = CCCPrice.ToString();
        //Convert DateTime to int
        int.TryParse(currentTime.ToString("HHmm"), out currentTimeInt);

    }

    void Update()
    {
        currentTime = timeController.currentTime;
        Events();
        UpdatePriceText();
    }

    private void UpdatePriceText()
    {
        MMUPriceTXT.text = MMUPriceString;
        MLTPriceTXT.text = MLTPriceString;
        RCIPriceTXT.text = RCIPriceString;
        TOGPriceTXT.text = TOGPriceString;
        CCCPriceTXT.text = CCCPriceString;
    }

    public void Events()
    {
        if(currentTime != null && currentTime.Hour % 2 == 0 && currentTime.Minute == 0)
        {
            Debug.Log("hueftghuef");
        }
        else
        {
            //do nothing
        }
    }
}