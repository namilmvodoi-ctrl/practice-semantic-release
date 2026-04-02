using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        // Tính năng: Quái vật di chuyển về phía trước
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}