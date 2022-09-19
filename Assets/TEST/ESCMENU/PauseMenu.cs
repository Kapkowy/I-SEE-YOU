using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel;
    public int counter;
    public bool otware = false;
    private inventory myScripts;
    void Start()
    {
        panel.SetActive(false);
        counter = 0;
        Time.timeScale = 1;
        myScripts = GetComponent<inventory>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            counter += 1;
            otware = true;
            panel.SetActive(true);
            Time.timeScale = 0;
            print(panel.name + " GAME TIME STOPPED");
        }
        if (counter == 2)
        {
            counter = 0;
            panel.SetActive(false);
            Time.timeScale = 1;
            otware = false;
            print(panel.name + " GAME TIME NORMAL");
        }
        if (counter == 1)
        {
            panel.SetActive(true);
        }
        else if (counter == 0)
        {
            panel.SetActive(false);
        }
    }
    
    public void OnClickens()
    {
        print("klik");
        SceneManager.LoadScene("MainMenu_1");
    }    
}
