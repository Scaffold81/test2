using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{  
    [SerializeField]
    private Text outClickCount = null;
    [SerializeField]
    Controller controller = null;
    [SerializeField]
    private InputField inputSpeed = null, inputDist = null, inputTime=null;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnClick(int clickCount)
    {

        outClickCount.text=""+ controller.GetClickCount(clickCount);
    }
    public void CubeParams()
    {
        float inputSpeedT = 0;
        float inputDistT = 0;
        float inputTimeT = 0;
        float.TryParse(inputSpeed.text, out inputSpeedT);
        float.TryParse(inputDist.text, out inputDistT);
        float.TryParse(inputTime.text, out inputTimeT);
        controller.SetCubeParametrs(inputSpeedT, inputDistT, inputTimeT);
    }
}
