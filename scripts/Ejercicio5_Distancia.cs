using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Distancia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform cylinder = GameObject.Find("Cylinder").transform;
        Transform cube = GameObject.Find("Cube").transform;
        double dist = Vector3.Distance(cylinder.position, cube.position);
        Debug.Log("Distancia entre el cilindro y el cubo: " + dist);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
