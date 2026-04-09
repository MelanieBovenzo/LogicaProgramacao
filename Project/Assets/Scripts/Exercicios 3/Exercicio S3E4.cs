using UnityEngine;

public class ExercicioS3E4 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        if (numero1 == numero2)
        {
            print("são iguais");
        }
        else
        {
            print("são diferentes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
