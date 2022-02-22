using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]float y= 0.01f;
    // Update is called once per frame
    void Update()
    {       
            transform.Translate(0,y,0);

    }
}
