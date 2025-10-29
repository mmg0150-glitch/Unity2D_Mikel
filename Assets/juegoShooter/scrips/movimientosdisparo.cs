using Unity.VisualScripting;
using UnityEngine;

public class movimientosdisparo : MonoBehaviour
{

    public float velocidadDeMovimiento;
    public float sensibilidadRaton;
    public GameObject prefabBala; // arrastra el prefab aqui 
    public GameObject puntoDisparo;
    public float fuerzaBala = 100f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // bloquear y ocultar el cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Estamos llamando a las teclas del teclado con una variable decimal para más precisión y con el nombre que decidamos 
        float izqder = Input.GetAxis("Horizontal");  // Para mover el personaje hacia los lados
        float delatra = Input.GetAxis("Vertical");    // Para mover el personaje hacia delante y atras

       transform.Translate(x: izqder * velocidadDeMovimiento * Time.deltaTime, 0, z: delatra * velocidadDeMovimiento * Time.deltaTime);

       //Rotación del ratón
        float movimientoX = Input.GetAxis("Mouse X");
        transform.Rotate(0, movimientoX * sensibilidadRaton, 0);

        if (Input.GetMouseButtonDown(0))
        {

            GameObject bala = Instantiate(prefabBala, puntoDisparo.transform.position, puntoDisparo.transform.rotation); // coger un prefab que es un objeto que hemos creado y subirlo a la escena, partida
            Rigidbody rbBala = bala.GetComponent<Rigidbody>();

            rbBala.AddForce(puntoDisparo.transform.forward * fuerzaBala, ForceMode.Impulse);
            Destroy(bala, 3f); // Se destruye la bala despues de 3 segundos

        }

    }









}




