using UnityEngine;

public class StreetMover : MonoBehaviour
{
    public float speed = 10f;
    public float endZ = -20f;     // Punto B
    public float resetZ = 40f;    // Punto A (donde reaparece)

    void Update()
    {
        // Mover siempre en un solo eje (Z)
        transform.position += Vector3.back * speed * Time.deltaTime;

        // Cuando llega al punto B ? reiniciar a A
        if (transform.position.z <= endZ)
        {
            Vector3 pos = transform.position;
            pos.z = resetZ;
            transform.position = pos;
        }

        // Bloquear rotación y otros ejes
        Vector3 lockedPos = transform.position;
        lockedPos.x = 0;
        lockedPos.y = 0;
        transform.position = lockedPos;

        transform.rotation = Quaternion.identity;
    }
}
