using UnityEngine;

public class AW1 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        while (i < numeros.Length)
        {
            print(numeros[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
