using UnityEngine;

public class Player : MonoBehaviour
{
    public float _sensetivity;
    public float _speed = 2f;
    public float _cameraSpeed;

    public Transform _targetPos;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    protected void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce(movement * _speed);
    }

    //protected void Rotate()
    //{
    //    Vector3 dir = _targetPos.position - transform.position;
    //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), _cameraSpeed * Time.deltaTime);
    //    Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
    //    _targetPos.position = ray.GetPoint(15);
    //}
}
