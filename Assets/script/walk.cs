using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
     [SerializeField] float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A))
        {
         transform.Translate(movespeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
         transform.Translate(-movespeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.W))
        {
         transform.Translate(0,0,-movespeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
         transform.Translate(0,0,movespeed*Time.deltaTime);
        }
    }
}
