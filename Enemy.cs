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
    public void TakeDamage(float damageAmount)
    {
        // Xử lý logic giảm máu của kẻ địch ở đây
        // Ví dụ: health -= damageAmount;
    }

    void Update()
    {
        transform.position += currentVelocity * Time.deltaTime;
    }
}