using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public GameObject nuke;
    Vector3 defaultpos;
    //Plate1= GameObject();
    //text = GetComponent<TMP_Text>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Reset()
    {
        Vector3 direction = new Vector3(-89, 0, 0);
        transform.eulerAngles = direction;
        nuke.transform.position = defaultpos;
    }
    public void Nuke(int power, int dir)
    { 
        if(power==0)
        {
            power = Random.Range(1, 4);

        }
        if (dir == 0)
        {
            dir = Random.Range(1, 4);

        }
        Vector3 direction = new Vector3(-89, 0, 0);
        int x = -89;
        switch (power)
        {

            case 1:
                x = -98;
                break;
            case 2:
                x = -110;
                break;
            case 3:
                x = -124;
                break;
            case 4:
                x = -136;
                break;
        }
        direction.x = x;
        transform.eulerAngles = direction;

    }
}
