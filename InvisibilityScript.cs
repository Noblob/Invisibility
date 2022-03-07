using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibilityScript : MonoBehaviour
{

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("i"))
        {
            Invisible();
        }

        if(Input.GetKeyUp("i"))
        {
            StopInvisible();
        }
    }

    void Invisible()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    void StopInvisible()
    {
        rend.GetComponent<Renderer>();
        rend.enabled = true;
    }
}
