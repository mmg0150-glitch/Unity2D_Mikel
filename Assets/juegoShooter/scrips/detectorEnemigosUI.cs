using UnityEngine;

public class detectorEnemigoUI : MonoBehaviour
{

    public ContadorMuertes contadorDeEnemigosMuertos;

    public GameObject prefabDestruido;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void RecibirDisparo()
    {
        GameObject destruido = Instantiate(prefabDestruido, transform.position, transform.rotation);
        Rigidbody[] fragmentos = destruido.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rb in fragmentos)
        {
            rb.AddExplosionForce(3000f, transform.position, 5f, 1f, ForceMode.Impulse);
        }
        Destroy(destruido, 5f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bala"))
        {
            RecibirDisparo();

            if (contadorDeEnemigosMuertos != null)
            {

                contadorDeEnemigosMuertos.SumarMuerte();

            }

            //Luego destruir bala y enemigo
            Destroy(other.gameObject);
            Destroy(gameObject);


        }
    }
}
    
