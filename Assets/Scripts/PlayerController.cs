using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput, verticalInput;
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
        Debug.Log(horizontalInput);
        Debug.Log(verticalInput);   
    }

    void InputHandler()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }

}
