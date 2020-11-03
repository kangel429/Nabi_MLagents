using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //transform.rotation = Quaternion.Euler(new Vector3(-3.13093949f, -0.0055407f, 3.14153055f));
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Euler(new Vector3(-1.58144949f, - 0.0055407f,   3.14153055f));
        transform.eulerAngles = new Vector3(-1.58144949f, -0.0055407f, 3.14153055f);
        //transform.rotation = Quaternion.Euler(new Vector3(-3.13093949f, -0.0055407f, 3.14153055f));
    }
}
