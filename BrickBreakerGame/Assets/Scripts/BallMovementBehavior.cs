using UnityEngine;

public class BallMovementBehavior : MonoBehaviour
{
  public new Rigidbody rigidbody;
  public float speed = 500f;

  private void Awake()
  {
    this.rigidbody = GetComponent<Rigidbody>();
  }

  private void Start()
  {
    Invoke(nameof(RandomTrajectory), 1f);
    
  }

  private void RandomTrajectory()
  {
    Vector3 force = Vector2.zero;
    force.x = Random.Range(-1f, 1f);
    force.y = -1f;
    
    this.rigidbody.AddForce(force.normalized * this.speed);
  }
}
