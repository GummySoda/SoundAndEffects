using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
