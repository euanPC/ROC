using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class nuke : MonoBehaviour
{
    public int npower = 0;
    public int ndir = 0;
    public GameObject Nukee;
    public int nukecomp = 0;
    Vector3 defaultpos;
    public int dircomp = 0;
    public GameObject lookat;
    public AudioSource winsound;
    public AudioSource pain;
    public AudioSource ts;
    public int score = 0;
    public int life = 3;
    public UnityEvent blastt;
    public float waittime = 10;
    public TMP_Text rounds;
    public int wartime = 10;
    public bool war = false;
    private IEnumerator coroutine;
    public GameObject start;
    public bool fail = false;
    public TMP_Text text;
    public UnityEvent startup;
    public GameObject canvas;
    public GameObject cam;
    public bool gameover = false;
    public GameObject canvass;
    public AudioSource tutorial;
    public TMP_Text counter;
    public int nextround = 0;
    public AudioSource tea;
    public AudioSource nukeeee;
    public GameObject manual;
    public bool Manuel = false;
    private bool failll = false;
    //Plate1= GameObject();
    //text = GetComponent<TMP_Text>();
    // Start is called before the first frame update
    void Start()
    {
        defaultpos = Nukee.transform.position;
        Reset();
        text.text = "Press n to start " +
            "Press M for Manual " +
            "Press T for tea";
    }
    public void WaitTimee(float wait)
    {
        waittime = wait;
        counter.text = $"Time:{wait}";
    }
    public void Roundss(float roundsss)
    {
        int r = ((int)roundsss);
        wartime = r;
        rounds.text = $"Rounds:{r}";
    }
    // Update is called once per frame
    void Update()
    {
        if(!start.activeInHierarchy)
            canvass.SetActive(true);
        if (Input.GetKeyDown(KeyCode.N)&&!start.activeInHierarchy&&!war&&!gameover)
        {
            tutorial.Stop();
            // Nuke(0, 0);
            canvass.SetActive(true);
            war = true;
            coroutine = nukes(waittime,wartime);
            StartCoroutine(coroutine);
        }
        if (Input.GetKeyDown(KeyCode.N) && gameover)
        {
            text.text = "Press n to start " +
            "Press M for Manual " +
            "Press T for tea";
            score = 0;
            canvas.SetActive(true);
            cam.SetActive(true);
            Reset();
            life = 3;
            gameover = false;
            canvass.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.T) && !start.activeInHierarchy)
        {
            tea.Play();
        }
        if (Input.GetKeyDown(KeyCode.M) && !start.activeInHierarchy)
        {

            Manuel = !Manuel;
        }
        if (Manuel)
        {
            if (manual.gameObject.transform.position.y < -8.84)
            {
                print("uppies");
                manual.gameObject.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            }
        }
        else
        {
            if (manual.gameObject.transform.position.y > -11.62)
            {
                print("downies");
                manual.gameObject.transform.Translate(Vector3.up * Time.deltaTime * -1, Space.World);
            }
        }
        print(manual.gameObject.transform.position.y);
            //if (Input.GetKey(KeyCode.Space))
            // Nuke(0, 1);
        }
    public IEnumerator nukes(float f,int warr)
    {
        while(war && warr > 0&&life>0)
        {
            Nuke(0, 0);
            for (float i = 0; i < f; i++)
            {
                yield return new WaitForSeconds(1);
                if (dircomp == 1 && nukecomp == 1)
                {
                    i = f;
                    break;
                }
                if (nextround == 1)
                {
                    i = f;
                    nextround = 0;
                    dircomp = 0;
                    nukecomp = 0;
                    break;
                }
            }
                    if (dircomp == 1 && nukecomp == 1)
            {
                print("Nuke");
            }
            else
            {
                if (!fail)
                {
                    ts.Play();
                    life--;
                    print("to slow");
                    text.text = "to slow";
                    if (life == 0)
                    {
                        fail = true;
                        warr = 0;
                        //war = false;
                    }
                }
            }
            Nuke(0, 0);
            warr--;

        }
        war = false;
        gameover = true;
        print($"{score}/{wartime}");
        text.text = $"{score}/{wartime} press n to return to menu";
    }
    public void Reset()
    {
        Vector3 direction = new Vector3(-89, 0, 0);
        transform.eulerAngles = direction;
        Nukee.transform.position = defaultpos;
    }
    public void Nuke(int power, int dir)
    {
        failll = false;
        nukeeee.Play();
        if (power == 0)
        {
            power = Random.Range(1, 5);

        }
        if (dir == 0)
        {
            dir = Random.Range(1, 5);

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
        Vector3 newpos = defaultpos;
        switch (dir)
        {

            case 1:
                newpos = new Vector3(50,17,13); //north
                break;
            case 2:
                newpos = new Vector3(9, 17, -15);//east
                break;
            case 3:
                newpos = new Vector3(-28, 17, 7);//south
                break;
            case 4:
                newpos = new Vector3(5, 17, 56);//west
                break;
        }
        npower = power;
        ndir = dir;
        Nukee.transform.position = newpos;
        nukecomp = 0;
        dircomp = 0;
        //Nukee.transform.LookAt(lookat.transform);
        blastt.Invoke();
    }
    public void faxclick(int input)
    {
        Debug.Log($"clicked {input}");
        if (npower == 0 || ndir == 0)
        {

        }
        else
        {
            if (life <= 0)
            {

            }
            else
            {
                if (input == npower)
                {
                    nukecomp = 1;

                }
                else
                {
                    if (ndir + 4 == input)
                    {
                        dircomp = 1;
                    }
                    else
                    {
                        pain.Play();
                        print("BAD");
                        text.text = "terrible job";
                        life--;
                        failll = true;
                        nextround = 1;
                        if (life <= 0)
                        {

                        }
                    }
                }
            }
        }
        if(dircomp==1 && nukecomp == 1)
        {
            text.text = "good job";
            winsound.Play();
            print("WELL DONE");
            npower = 0;
            score++;
            Reset();
        }
    }
}
