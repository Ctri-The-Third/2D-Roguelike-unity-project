using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DeltaDNA;
namespace Completed
{ 
public class deltaDNA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Testing initiation of SDK " + GameManager.instance.getLevel());
        if (GameManager.instance.getLevel() <= 1)
        {
            DDNA.Instance.StartSDK();
        }
            Debug.Log("Successful initiation? " + DDNA.Instance.isActiveAndEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}