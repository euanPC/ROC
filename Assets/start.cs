using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject canvas;
    public GameObject cam;
    public GameObject canvass;
    public AudioSource tutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            S();
        }
    }
    public void S()
    {
        cam.SetActive(false);
        canvas.SetActive(false);
        canvass.SetActive(true);
        tutorial.Play();
    }
    private void OnMouseDown()
    {
        print("s");
    }
}
