using UnityEngine;


public sealed class CameraController : MonoBehaviour
{
    public Player Player;
    private Vector3 _offset;

    [SerializeField] float _sensitivity;
    [SerializeField] float radius = 1;
    [SerializeField] float alpha = 0;

    private void FixedUpdate()
    {
        AngleRotation();
        LookToPlayer();
    }

    private void LookToPlayer()
    {
        _offset = Player.transform.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(_offset);
        transform.rotation = rotation;
    }

    private void AngleRotation()
    {
        float x0 = Player.transform.position.x;
        float z0 = Player.transform.position.z;

        transform.position = new Vector3(
            x0 + radius * Mathf.Cos(alpha),
            transform.position.y,
            z0 + radius * Mathf.Sin(alpha)
            );

        alpha += Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
    }
}

