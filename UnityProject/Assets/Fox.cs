using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 500f)]
    public float speed = 50f;

    public SpriteRenderer sr;
    
    public Transform fox;

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;

        fox.Translate(h*speed, 0, 0);

    }
   

    private void Update()
    {
        Move();
    }

   
}
