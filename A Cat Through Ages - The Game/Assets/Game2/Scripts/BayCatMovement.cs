using UnityEngine;


public class BayCatMovement : MonoBehaviour
{

    public float MoveSpeed;

    private Vector3 _mVelocity = Vector3.zero;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed * Time.fixedDeltaTime * 10f, 0,
            Input.GetAxis("ZAxis") * MoveSpeed * Time.fixedDeltaTime * 10f);
        _rb.velocity = Vector3.SmoothDamp(_rb.velocity, targetVelocity, ref _mVelocity, 0.05f);

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var diff = hit.point - transform.position;
            diff.Normalize();

            float rotZ = Mathf.Atan2(diff.x, diff.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(90f, rotZ, 0f);
        }
    }
}
