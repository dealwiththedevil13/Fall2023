using UnityEngine;

public class BallMovementBehavior : MonoBehaviour
{
  public object Rigidbody { get; set; }
  void Start()
  {
    if (GetComponent(<Rigidbody > () == null)
    {
      Rigidbody rb = gameObject.AddComponent<Rigidbody>();
    }
  }

  
}
