using UnityEngine;

public class ExercicioS4E13 : MonoBehaviour
{
    [SerializeField] bool temChave = false;
    [SerializeField] bool portaDestravada = true;
    void Start()
    {
        if (temChave || portaDestravada)
        {
            print("Acesso permitido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
