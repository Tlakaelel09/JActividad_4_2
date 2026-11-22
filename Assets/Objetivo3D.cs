using UnityEngine;

public class Objetivo3D : MonoBehaviour
{
    public int puntos = 10;
    public float rangoPiso = 8f;

    void Update()
    {

        transform.Rotate(Vector3.up * 90f * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GestorPuntaje3D.instancia != null)
            {
                GestorPuntaje3D.instancia.SumarPuntos(puntos);
            }

            float nuevoX = Random.Range(-rangoPiso, rangoPiso);
            float nuevoZ = Random.Range(-rangoPiso, rangoPiso);
            transform.position = new Vector3(nuevoX, 1f, nuevoZ);
        }
    }
}