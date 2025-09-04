using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;
    public float bulletForce = 500f;
    public Transform shootPoint;
    public GameObject bulletPrefab;

    void Update()
    {
        // ----------- 이동 (앞/뒤) -----------
        if (Input.GetKey(KeyCode.W))  // 앞으로
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))  // 뒤로
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // ----------- 회전 (좌/우) -----------
        if (Input.GetKey(KeyCode.A))  // 왼쪽 회전
        {
            transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))  // 오른쪽 회전
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }

        // ----------- 발사 -----------
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletClone = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.AddForce(shootPoint.forward * bulletForce);
    }
}
