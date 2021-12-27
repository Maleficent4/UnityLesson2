using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);

        gameObject.transform.position = new Vector3(0, 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
           gameObject.transform.position += new Vector3(0, 0, 0.02f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position -= new Vector3(0, 0, 0.02f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= new Vector3(0.02f, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.02f, 0, 0);
        }
    }
}
