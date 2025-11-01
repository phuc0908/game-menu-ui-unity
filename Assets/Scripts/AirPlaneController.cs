using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 300f; // tốc độ di chuyển

    void Update()
    {
        // Di chuyển lên
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        // Di chuyển xuống
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Di chuyển sang trái
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // Di chuyển sang phải
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
