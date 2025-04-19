using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public volatile bool movingLeft = true;
    public bool firstInput = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameStarted)
        {
            Move();
            CheckInput();
        }
    }

    private void Move()
    {
        transform.position += moveSpeed * Time.deltaTime * transform.forward;
    }

    private void CheckInput()
    {
        if(firstInput)
        {
            firstInput = false;
            return;
        }

        if (Input.GetMouseButtonDown(0)) 
        {
            ChangeDirection();
        }
    }

    private void ChangeDirection()
    {
        movingLeft = !movingLeft;
        transform.rotation = movingLeft ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 90, 0);
    }
}
