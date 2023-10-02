using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_Esferas : MonoBehaviour
{
    
    GameObject[] spheres;
    GameObject nearest;
    GameObject farthest;
    Material farthest_material;
    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("Group2");
        nearest = spheres[0];
        farthest = spheres[0];
        float nearest_dist = 9999f;
        float farthest_dist = 0f;

        foreach (GameObject sphere in spheres) {
            float distance = Vector3.Distance(
                             sphere.GetComponent<Transform>().position,
                             transform.position);
            if (distance < nearest_dist) {
                nearest_dist = distance;
                nearest = sphere;
            }
            if (distance > farthest_dist) {
                farthest_dist = distance;
                farthest = sphere;
            }
        }
        Transform near_tf = nearest.GetComponent<Transform>();
        near_tf.position = near_tf.position + new Vector3(0f, 2f, 0f);
        farthest_material = farthest.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            farthest_material.color = Random.ColorHSV(0f, 1f,    // Hue
                                                      1f, 1f,    // Saturation
                                                      0.5f, 1f,  // Value
                                                      1f, 1f);   // Alpha
        }
    }
}
