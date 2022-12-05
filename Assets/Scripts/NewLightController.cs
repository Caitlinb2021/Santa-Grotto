using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLightController : MonoBehaviour
{
    public GameObject[] LightBulbs;
    public Material[] LightBulbMaterials;
    public Material OffMaterial;
    public bool LightSwitchTest;


    // Start is called before the first frame update


    private void Update()
    {
        if(LightSwitchTest)
        {
            turnOnLights();
        }
        else
        {
            turnOffLights();
        }
    }

    public void LightSwitchControl()
    {
        if (LightSwitchTest)
        {
            turnOnLights();
            LightSwitchTest = false; 
        }
        else
        {
            turnOffLights();
            LightSwitchTest = true; 
        }
    }


    public void turnOnLights()
    {
        for (int i = 0; i < LightBulbs.Length; i++)
        {
            LightBulbs[i].GetComponent<MeshRenderer>().material = LightBulbMaterials[i];
            //Console.WriteLine(LightBulbs[i]);
        }

    }
    public void turnOffLights()
    {
        for (int i = 0; i < LightBulbs.Length; i++)
        {
            LightBulbs[i].GetComponent<MeshRenderer>().material = OffMaterial;
            //Console.WriteLine(LightBulbs[i]);
        }
    }
}
