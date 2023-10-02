using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_DosVectores : MonoBehaviour
{
    public Vector3 Vec1 = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 Vec2 = new Vector3(0.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("\tMagnitud de Vec1: " + Vec1.magnitude +
                  "\n\t\tMagnitud de Vec2: " + Vec2.magnitude);
        Debug.Log("Ángulo: " + Vector3.Angle(Vec1, Vec2));
        Debug.Log("Distancia: " + Vector3.Distance(Vec1, Vec2));
        Debug.Log("Vector a mayor altura (y): " + (Vec1.y > Vec2.y ? "Vec1" : "Vec2"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
