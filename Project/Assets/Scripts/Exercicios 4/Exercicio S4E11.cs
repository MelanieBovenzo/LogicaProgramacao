using UnityEngine;

public class ExercicioS4E11 : MonoBehaviour
{
    [SerializeField] bool estaNoChao = true;
    void Start()
    {
        if (estaNoChao)
        {
            print("pode pular");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
