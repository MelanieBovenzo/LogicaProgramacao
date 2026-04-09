using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class EW4 : MonoBehaviour
{
    void Start()
    {
        int i = 0;

        while (i <= 20)
        {
            if (i % 2 == 0)
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
