using UnityEngine;

public class RotateSteroid : MonoBehaviour
{
    public float caida = 5;
    void Start()
    {
        //Velocidad angular o de rotaci�n = valor alaatorio en una esfera de radio 1 * la caida
        //Random.insideUnitSphere * caida;
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * caida;
    }

}
