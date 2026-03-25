using UnityEngine;

public class ExercicioS4E12 : MonoBehaviour
{
    [SerializeField] bool temArma = true;
    [SerializeField] bool temMunicao = false;
    void Start()
    {
        if (temArma && temMunicao)
        {
            print("Pode atirar");
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
