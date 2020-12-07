using System.Collections;
using System.Collections.Generic;

using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{    public  float speed=1;
     public  float dist=1;
    private Vector3 startPos=new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(Vector3.Distance(startPos,transform.position)> dist)
        {
            Destroy(gameObject);
        }
    }
}
