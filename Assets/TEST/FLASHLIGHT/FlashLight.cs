using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public Light lightC;
    public Transform lightT;
    public Transform camT;
    public float t;

    public int counter;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        lightT.position = Vector3.Slerp(lightT.position, camT.position, t);
        lightT.rotation = Quaternion.Slerp(lightT.rotation, camT.rotation, t);

        if (Input.GetKeyDown(KeyCode.F))
        {
            counter += 1;
        }

        if (counter == 2)
        {
            counter = 0;
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
