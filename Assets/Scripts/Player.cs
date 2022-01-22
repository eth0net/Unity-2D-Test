using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    public float speed = 100;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        if (_animator == null)
        {
            Debug.LogError("Player is missing a Animator component");
        }

        _rigidbody = GetComponent<Rigidbody2D>();
        if (_rigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        var v = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (v != Vector2.zero)
        {
            v *= speed * Time.deltaTime;
            _animator.SetFloat("VelX", v.x);
            _animator.SetFloat("VelY", v.y);
            _animator.Play("Move");
        }
        else
        {
            _animator.Play("Idle");
        }

        _rigidbody.velocity = v;
    }
}