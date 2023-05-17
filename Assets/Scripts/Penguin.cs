using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    void OnMouseDown()
    {

        GetComponent<SpriteRenderer>().color = new Color(0,150,255);

    }

    void OnMouseUp()
    {

        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
