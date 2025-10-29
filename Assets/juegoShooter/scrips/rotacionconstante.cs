using UnityEngine;
using UnityEngine.Rendering;

public class RotacionConstante : MonoBehaviour
{
    public float velocidadRotacion = 5f;
    public Vector3 rotacionItem;
    // rota 50 grados por segundo en el eje Y

    void Update()
    {
        transform.Rotate(rotacionItem * Time.deltaTime * velocidadRotacion);
    }
}
