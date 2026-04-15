using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class EW6 : MonoBehaviour
{
    void Start()
    {
        int vidas = 3;

        while (vidas >= 0)
        {
            if (vidas > 0)
            {
                print("Jogador Vivo");
            }
            else
            {
                print("Jogador Morto");
            }
            vidas--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
