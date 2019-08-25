using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour
{
    public Button add, delete, back, ok;
    public Text count, cost;
    int cnt = 0;
    decimal cst = 30000.0m;
    public GameObject[] b = new GameObject[7];
    public GameObject j, b1;

    // Start is called before the first frame update
    public int f = 0;
    void Start()
    {


        foreach (GameObject i in b)
        {
            i.SetActive(false);
        }


        add.onClick.AddListener(Change);
        delete.onClick.AddListener(Change2);
        back.onClick.AddListener(quit);
        cost.text = cst.ToString();
        ok.onClick.AddListener(stopManipulation);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Change()
    {
        Move.t1 = 1;
        Add.t = 1;
        cnt++;
        count.text = cnt.ToString();
        cst += 10000.0m;
        cost.text = cst.ToString();


    }
    public void Change2()
    {
        Move.d1 = 1;
        Add.d = 1;
        if (cnt > 0)
            cnt--;
        count.text = cnt.ToString();
        if (cst > 30000.0m)
            cst -= 10000.0m;
        cost.text = cst.ToString();
    }

    public void quit()
    {
        Application.Quit();
    }

    public void stopManipulation()
    {
        GoogleARCore.Examples.ObjectManipulation.ManipulationSystem.j = 1;
        foreach (GameObject i in b)
        {
            i.SetActive(true);
        }
        j.SetActive(false);
    }

    public void clr()
    {
        foreach (GameObject i in b)
        {
            i.SetActive(false);
        }
        b1.SetActive(false);
        j.SetActive(false);
    }


    public void nextScene()
    {
        SceneManager.LoadScene(2);
    }

    public void oldScene()
    {
        SceneManager.LoadScene(0);
    }
}
