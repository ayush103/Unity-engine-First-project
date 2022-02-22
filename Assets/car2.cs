using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2 : MonoBehaviour
{
    [SerializeField]float movementspeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]float y=0f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*movementspeed, z = Input.GetAxis("Vertical")*Time.deltaTime*movementspeed;
        transform.Translate(x,y,z);
    }
}
