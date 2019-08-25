using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static int t1 = 0,d1=0;
    int f = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t1==1)
        {
            transform.Translate(-1.23f, 0, 0);
            t1 = 0;
            f++;
        }
        if (d1 == 1)
        {
            if (f> 0)
            {
                transform.Translate(1.23f, 0, 0);
                d1 = 0;
                f--;
            }
            
        }
    }
    
}
