using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public GameObject asteroide;
    public Vector3 position;
    public int numeroDeAsteroides;
    public float esperaInicial;
    public float esperaEntreAsteroides;
    public float esperaEntreOlas;
    public float totalOlas;
    void Start()
    {
        StartCoroutine(crearAsteroides());
    }
    IEnumerator crearAsteroides()
    {
        yield return new WaitForSeconds(esperaInicial);
        for (int y = 1; y <= totalOlas; y++)
        {
            for (int i = 0; i < numeroDeAsteroides; i++)
            {
                Vector3 posicionAsteroide = new Vector3(Random.Range(-13.5f, 13.5f), Random.Range(5f, 2f), position.z);          
                Quaternion rotacionAsteroide = Quaternion.identity;

                Instantiate(asteroide, posicionAsteroide, rotacionAsteroide);
                yield return new WaitForSeconds(esperaEntreAsteroides);
            }
            Debug.Log("Ola numero: " + y);
            yield return new WaitForSeconds(esperaEntreOlas);
        }
    }

}
