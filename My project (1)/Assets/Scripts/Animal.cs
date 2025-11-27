using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string _name;
    protected int _age;
    protected float _speed;

    public abstract void Move();
    public abstract void Speak();
}
