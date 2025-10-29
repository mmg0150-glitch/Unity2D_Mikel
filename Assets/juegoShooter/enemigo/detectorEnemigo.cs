using UnityEngine;

public class detectorEnemigo : MonoBehaviour
{

    public ContadorMuertes contadorMuertes;

    public GameObject prefabDestruido;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bala"))
        {
            RecibirDisparo();

            
           //Luego destruir bala y enemigo
            Destroy(other.gameObject);
            Destroy(gameObject);

      
        }
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
}
