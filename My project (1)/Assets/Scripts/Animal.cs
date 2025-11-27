using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField]
    protected AudioSource _sound;

    protected string _name;
    protected int _age;
    protected float _speed;

    public abstract void Move();
    public virtual void Speak() {
        _sound.Play();
    }
}
