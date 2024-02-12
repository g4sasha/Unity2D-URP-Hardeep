using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _fallSpeed = 100f;
    [SerializeField] private float _rotationSpeed = 125f;
    
    private void Update()
    {
        transform.Rotate(0f, 0f, _rotationSpeed * Time.deltaTime * -1f);
        transform.position += Vector3.down * (_fallSpeed * Time.deltaTime);
        transform.position += new Vector3(Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime, 0f, 0f);
    }
}