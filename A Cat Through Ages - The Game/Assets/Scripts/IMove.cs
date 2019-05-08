using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IMove {

    event System.Action<Input> OnPlayerInput;
    void Move();
    void Jump();
}
