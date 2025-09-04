using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane") // Plane 바닥에 닿으면
        {
            Destroy(gameObject, 2f); // 2초 뒤에 삭제
        }
    }
}
