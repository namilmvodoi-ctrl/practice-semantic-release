using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        // Tính năng: Quái vật di chuyển về phía trước
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        // Tính năng: Quái vật nhận sát thương
        // Giảm máu của quái vật và kiểm tra nếu nó chết
    }
}