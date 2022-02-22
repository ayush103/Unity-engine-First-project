using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Will it work for me?");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f,0,0);
    }
}
