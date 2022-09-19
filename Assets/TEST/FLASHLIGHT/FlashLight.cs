using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour
{
    public Light lightC;
    public Transform lightT;
    public Transform camT;
    public float t;
    public TextMeshProUGUI d;

    public int counter;

    void Start()
    {
        counter = 1;
    }

    void Update()
    {
        lightT.position = Vector3.Slerp(lightT.position, camT.position, t);
        lightT.rotation = Quaternion.Slerp(lightT.rotation, camT.rotation, t);
   
        if (Input.GetKeyDown(KeyCode.F))
        {
            counter += 1;
            print(counter + " True");
            d.text = "[BETA] F to turn off";
        }

        if (counter == 2)
        {
            counter = 0;
            print(counter + " False");
            d.text = "[BETA] F to turn on";
        }
        if (counter == 1)
        {
            lightC.intensity = 1;
        }
        else if (counter == 0)
        {
            lightC.intensity = 0;

            lightT.position = Vector3.Slerp(lightT.position, camT.position, t);
            lightT.rotation = Quaternion.Slerp(lightT.rotation, camT.rotation, t);
        }
    }
}
