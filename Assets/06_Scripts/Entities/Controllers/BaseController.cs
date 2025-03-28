using DG.Tweening;
using System;
using UnityEngine;

public enum BaseState
{
    Destroyed,
    Birth,
    Stand,
    Death
}

public abstract class BaseController : MonoBehaviour
{
    public bool IsDead { get { return state == BaseState.Death || state == BaseState.Destroyed; } }

    public event Action OnBirth;
    public event Action OnStand;
    public event Action OnDeath;
    public event Action OnDestoryed;

    private BaseState state;

    private readonly SequenceHandler sequenceHandler = new();

    private void Awake() => Initialize();
    private void OnDestroy() => Deinitialize();
    protected void BindSequences(BaseState type, params Func<Sequence>[] sequences) => sequenceHandler.Bind(type, sequences);

    protected virtual void Initialize()
    {
        sequenceHandler.Initialize();
    }

    protected virtual void Deinitialize()
    {
        sequenceHandler.Deinitialize();
    }

    public virtual void Clear()
    {
        OnBirth = null;
        OnStand = null;
        OnDeath = null;
        OnDestoryed = null;
    }

    public virtual void Birth()
    {
        state = BaseState.Birth;

        sequenceHandler.Birth.Restart();

        OnBirth?.Invoke();
    }

    public virtual void Stand()
    {
        state = BaseState.Stand;

        sequenceHandler.Stand.Restart();

        OnStand?.Invoke();
    }

    public virtual void Death()
    {
        state = BaseState.Death;

        sequenceHandler.Stand.Pause();
        sequenceHandler.Death.Restart();

        OnDeath?.Invoke();
    }

    public virtual void Destroy()
    {
        state = BaseState.Destroyed;

        sequenceHandler.Stand.Pause();

        OnDestoryed?.Invoke();
        ResourceManager.Instance.Destroy(gameObject);
    }
}