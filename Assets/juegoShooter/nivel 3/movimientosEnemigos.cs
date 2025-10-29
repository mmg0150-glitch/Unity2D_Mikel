using UnityEngine;
using UnityEngine.Rendering;

public class movimientosEnemigos : MonoBehaviour
{



    public float velocidad = 3F;
    public float rangoSuelo = 100f;

    private Vector3 destino;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ElegirNuevoDestino(); //elegimos primer destino aleatorio
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidad + Time.deltaTime);

        if (transform.position==destino)
        {
            ElegirNuevoDestino();
        }

    }




    void ElegirNuevoDestino()
    {
        float rangoAleatorioEnX = Random.Range(-rangoSuelo, rangoSuelo);
        float rangoAleatorioEnZ = Random.Range(-rangoSuelo, rangoSuelo);

        destino = new Vector3( rangoAleatorioEnX, transform.position.y, rangoAleatorioEnZ );
    }
}
