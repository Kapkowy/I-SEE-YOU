using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class inventory : MonoBehaviour
{
    public GameObject eq;
    public GameObject status;
    public int kunter;
    private PauseMenu myScript;
    // Start is called before the first frame update
    void Start()
    {
        eq.SetActive(false);
        kunter = 0;
        myScript = GetComponent<PauseMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myScript.otware == false)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                kunter += 1;
                eq.SetActive(true);
                status.SetActive(true);
                print(eq.name + " eq is opened");
            }
            if (kunter == 2)
            {
                kunter = 0;
                eq.SetActive(false);
                status.SetActive(false);
                print(eq.name + " eq not open");
            }
            if (kunter == 1)
            {
                eq.SetActive(true);
                status.SetActive(true);
            }
            else if (kunter == 0)
            {
                eq.SetActive(false);
                status.SetActive(false);
            }
        }
        else if (myScript.otware == true)
        {
            eq.SetActive(false);
            status.SetActive(false);
        }
    }
}
