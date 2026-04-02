using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Biến cũ (movementSpeed) ĐÃ BỊ XÓA BỎ HOÀN TOÀN
    // Thay bằng hệ thống vận tốc mới phức tạp hơn
    public Vector3 currentVelocity;

    public void ApplySlowEffect(float slowFactor)
    {
        currentVelocity *= slowFactor;
    }

    void Update()
    {
        transform.position += currentVelocity * Time.deltaTime;
    }
}