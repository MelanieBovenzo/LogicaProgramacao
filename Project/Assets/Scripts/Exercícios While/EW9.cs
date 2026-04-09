using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class EW9 : MonoBehaviour
{
    void Start()
    {
        int i = 0;

        while (true)
        {
            ++i;
            if (i == 7)
            {
                print(i);
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
