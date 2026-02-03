using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject menuu;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print("piss");
    }
    public void Menu()
    {
        print("menu");
        if (start.activeInHierarchy)
        {
            menuu.SetActive(true);
            start.SetActive(false);
        }
        else
        {
            menuu.SetActive(false);
            start.SetActive(true);
        }
    }
}
