using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void blastt()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 size = transform.localScale;
        size.x++;
        size.y++;
        transform.localScale = size;
    }
}
