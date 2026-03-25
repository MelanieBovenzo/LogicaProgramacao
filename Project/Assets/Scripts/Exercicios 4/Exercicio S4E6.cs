using UnityEngine;

public class ExercicioS4E6 : MonoBehaviour
{
    int danoBase = 10;
    bool criico = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (criico)
        {
            print(danoBase * 2);
        }
    }
}
