using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class but : MonoBehaviour
{
    public int key;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public UnityEvent faxclick;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Debug.Log("click");
        faxclick.Invoke();
    }
}
