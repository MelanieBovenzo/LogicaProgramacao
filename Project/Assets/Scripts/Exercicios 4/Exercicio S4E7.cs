using UnityEngine;

public class ExercicioS4E7 : MonoBehaviour
{
    [SerializeField] bool temChave = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (temChave) 
        {
            print("porta aberta");
        }
        else
        {
            print("porta fechada");
        }
    }
}
