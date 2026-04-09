using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class EW5 : MonoBehaviour
{
    void Start()
    {
        int i = 1;

        while (i <= 20)
        {
            if (i % 3 == 0)
            {
                print("Fizz");
            }
            else
            {
                print(i);
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
