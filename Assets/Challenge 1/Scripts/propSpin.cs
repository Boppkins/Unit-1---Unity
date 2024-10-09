using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propSpin : MonoBehaviour
{

    private float propSpeed = 10000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propSpeed * Time.deltaTime);
    }
}
