using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_ColorChange : MonoBehaviour
{
    GameObject cylinder;
    GameObject cube;
    Material cylinder_material;
    Material cube_material;
    // Start is called before the first frame update
    void Start()
    {
        cylinder = GameObject.Find("Cylinder");
        cylinder_material = cylinder.GetComponent<Renderer>().material;
        cube = GameObject.Find("Cube");
        cube_material = cube.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            cylinder_material.color = Random.ColorHSV(0f, 1f,    // Hue
                                                      1f, 1f,    // Saturation
                                                      0.5f, 1f,  // Value
                                                      1f, 1f);   // Alpha
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            cube_material.color = Random.ColorHSV(0f, 1f,    // Hue
                                                  1f, 1f,    // Saturation
                                                  0.5f, 1f,  // Value
                                                  1f, 1f);   // Alpha
        }
    }
}
