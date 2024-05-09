using System;
using Mediator.Scripts;
using UnityEngine;
using Zenject;

public class Level : IDisposable
{
    private readonly InputHandler _inputHandler;
    public event Action Defeat;

    public Level(InputHandler inputHandler)
    {
        _inputHandler = inputHandler;
        _inputHandler.Defeated += OnDefeat;
        Start();
    }

    public void Dispose()
    {
        _inputHandler.Defeated -= OnDefeat;
    }
    
    public void Start()
    {
        Debug.Log("StartLevel");
    }

    public void Restart()
    {
        Start();
    }

    private void OnDefeat()
    {
        Defeat?.Invoke();
    }
}
