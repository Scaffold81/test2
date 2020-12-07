using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{   [SerializeField]
    Model model=null;
    [SerializeField]
    ModelCube modelCube = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetClickCount(int count)
    {
        return model.ClickCount(count);
    }
    public void SetCubeParametrs(float speed, float dist, float time)
    {
        modelCube.cubeSpeed = speed;
        modelCube.cubeMaxDist = dist;
        modelCube.timeTimer = time;
    }
}
