using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerNabi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }  


    // Update is called once per frame
    void Update()
    {

        //Debug.Log(Quaternion.Euler(0.01952095f, -0.01255011f, 0.08139092f));

        Move_Nabi();
    }

    void Move_Nabi()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0,0, -0.3f));
            //transform.position += transform.right * 1f;

        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0.3f, 0, 0));
            //transform.position += transform.forward * 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, 0, 0.3f));
            //transform.position += transform.right*-1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-0.3f, 0, 0));
            //transform.position += transform.forward * -1f;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0.5f, 0));
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, -0.5f, 0));
        }
    }
}
