using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 10f)]
    public float speed = 2f;

    public Transform fox;

    private void Move()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        fox.Translate(speed, 0, 0);

    }

    private void Update()
    {
        Move();
    }
}
