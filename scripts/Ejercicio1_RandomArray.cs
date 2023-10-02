using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_RandomArray : MonoBehaviour
{
    // Start is called before the first frame update
    int range = 15;
    public int minimum = 0;
    public int maximum = 26; 
    int[] numberArray;
    void Start()
    {
        numberArray = new int[range];
        for (int i = 0; i < range; ++i) {
            numberArray[i] = Random.Range(minimum, maximum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        numberArray[Random.Range(0, range)] = Random.Range(minimum, maximum);
        string nums = "";
        foreach (int num in numberArray) {
            if (num > 15) {
                nums += num + " ";
            }
        }
        Debug.Log(nums);
    }
}
