using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class EW10 : MonoBehaviour
{
    void Start()
    {
        int i = 1;

        while (i <= 20)
        {
            if (i % 2 == 0)
            {
                print("Par");
            }
            else
            {
                print("Ímpar");
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
