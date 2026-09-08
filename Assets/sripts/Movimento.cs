using UnityEngine;

public class Movimento : MonoBehaviour
{
    float spd = 5f;
    float horizontal;
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * horizontal * spd * Time.deltaTime;
    }
}
