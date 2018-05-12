using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservableProperty<T>
{
    void AddObserver(Action<T> observer);
    T Field { get; set; }
}
