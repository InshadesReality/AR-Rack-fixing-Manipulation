using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    public static int t = 0,d=0;
    float x = 0;
    public GameObject prefab;
    public GameObject[] g=new GameObject[50];
    public int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t==1)
        {

            g[i] = Instantiate(prefab,transform.position,transform.rotation);
            t = 0;
            x += 1.23f;
            g[i].transform.Translate(-x, 0, 0);
            i++;
            
            
        }
        if(d==1)
        {
            Destroy(g[i - 1]);
            i--;
            x -= 1.23f;
            d = 0;
        }
    }
}
