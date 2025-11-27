using UnityEngine;
using UnityEngine.InputSystem;

public class Cat : Animal, IPlay
{

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _name = "Kitty";
        _age = 3;
        _speed = 5f;
    }

    private void FixedUpdate()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.E))
        {
            Speak();
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            Play();
        }
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

    }

    public override void Speak()
    {
        base.Speak();
        Debug.Log($"{_name} says: Meow!");
    }

    public void Play()
    {
        Debug.Log($"{_name} plays with a yearn!");
    }
}
