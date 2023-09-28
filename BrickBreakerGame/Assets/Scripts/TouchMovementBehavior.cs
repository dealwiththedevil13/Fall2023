using UnityEngine;

public class TouchMovementBehavior : MonoBehaviour
{
    public Rigidbody Rigidbody { get; private set; }
    private Vector2 startPosition; 
    

    private void Awake()
    {
        this.Rigidbody = GetComponent<Rigidbody>();
        
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Store the initial touch position
                    startPosition = touch.position;
                    break;
                case TouchPhase.Moved:
                    // Calculate the difference between the initial and current touch position
                    float deltaX = touch.position.x - startPosition.x;

                    // Move the game object based on the calculated delta
                    transform.Translate(new Vector3(deltaX * Time.deltaTime, 0, 0));
                    break;
            }
        }
    }

    }
