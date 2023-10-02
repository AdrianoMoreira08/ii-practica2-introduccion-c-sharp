using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6_Alinear : MonoBehaviour
{
    // Start is called before the first frame update
    Transform cylinder;
    Transform cube;
    Vector3 displacement;
    void Start()
    {
        cylinder = GameObject.Find("Cylinder").transform;
        cube = GameObject.Find("Cube").transform;
    }

    // Update is called once per frame
    void Update()
    {
        cylinder.position = new Vector3(transform.position.x + 5,
                                        cylinder.position.y,
                                        cylinder.position.z);
        cube.position = new Vector3(transform.position.x - 5,
                                    cube.position.y,
                                    cube.position.z);
}
}
