using UnityEngine;

public class RoadPiece : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Mover solo hacia atrás (Z-)
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Despawn"))   // solo destruye si toca el trigger correcto
        {
            Destroy(gameObject);
        }
    }
}
    