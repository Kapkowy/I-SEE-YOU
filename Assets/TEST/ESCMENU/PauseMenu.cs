using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }
}
