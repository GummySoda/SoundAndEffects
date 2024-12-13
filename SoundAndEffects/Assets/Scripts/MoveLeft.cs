using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 20;
    private PlayerController PlayerControllerScript;
    
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.Gameover == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
       


    }
}
