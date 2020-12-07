using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ModelCube : MonoBehaviour
{   [SerializeField]
    private Move cubeprefab = null;

    public float cubeSpeed=1,  cubeMaxDist=1, timeTimer = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("TimerInstantiate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    IEnumerator TimerInstantiate()
    {
        while (true) {
            yield return new WaitForSeconds(timeTimer);
            InstantiateObj();
        } 
    }
    void InstantiateObj()
    {
        Move cubeMoved= Instantiate(cubeprefab, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z+10 ), Quaternion.identity);
        cubeMoved.speed = cubeSpeed;
        cubeMoved.dist = cubeMaxDist;
    }
}
