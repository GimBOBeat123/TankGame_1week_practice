using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane") // Plane �ٴڿ� ������
        {
            Destroy(gameObject, 2f); // 2�� �ڿ� ����
        }
    }
}
