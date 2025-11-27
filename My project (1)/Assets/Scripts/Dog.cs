using UnityEngine;
using UnityEngine.InputSystem;

public class Dog : Animal, IPlay
{

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _name = "Buddy";
        _age = 4;
        _speed = 7f;
    }

    private void FixedUpdate()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            Speak();
        }
        if (Input.GetKeyDown(KeyCode.RightControl)) {
            Play();
        }
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

    }

    public override void Speak()
    {
        base.Speak();
        Debug.Log($"{_name} says: Woof!");
    }

    public void Play()
    {
        Debug.Log($"{_name} plays with a bone!");
    }
}
