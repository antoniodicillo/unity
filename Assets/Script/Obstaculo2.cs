using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * 0.6f * Time.deltaTime);
        
    }

}
