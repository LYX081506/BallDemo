using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}