using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
    [Header("Trigger")]
    public GameObject triggerGameObject;
    public GameObject triggerImage;

    private void Start()
    {
        triggerImage.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        triggerImage.SetActive(true);
    }

}
