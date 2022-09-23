using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject eq;
    public GameObject status;
    public GameObject stamina;
    public int kunter;
    private PauseMenu myScript;

    // Start is called before the first frame update
    void Start()
    {
        eq.SetActive(false);
        stamina.SetActive(false);
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
                transform.localScale = new Vector3(0, 0, 0);
                LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.3f).setDelay(0.5f).setOnComplete(Update);
                kunter += 1;
                eq.SetActive(true);
                status.SetActive(true);
                stamina.SetActive(true);
                print(eq.name + " eq is opened");
            }
            if (kunter == 2)
            {
                kunter = 0;
                eq.SetActive(false);
                stamina.SetActive(false);
                status.SetActive(false);
                print(eq.name + " eq not open");
            }
            if (kunter == 1)
            {
                eq.SetActive(true);
                status.SetActive(true);
                stamina.SetActive(true);
            }
            else if (kunter == 0)
            {
                eq.SetActive(false);
                status.SetActive(false);
                stamina.SetActive(false);
            }
        }
        else if (myScript.otware == true)
        {
            eq.SetActive(false);
            stamina.SetActive(false);
            status.SetActive(false);
        }
    }
}
