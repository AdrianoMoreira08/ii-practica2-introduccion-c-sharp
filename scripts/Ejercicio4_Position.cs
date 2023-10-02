using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_Position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
        Debug.Log("Position: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
