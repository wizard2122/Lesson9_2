using System;
using UnityEngine;
using Zenject;

namespace Mediator.Scripts
{
    public class InputHandler : ITickable
    {
        public event Action Defeated;

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Defeated?.Invoke();
        }
    }
}