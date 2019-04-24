using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShoot{

    event System.Action CantShoot;

    void Shoot();
    //reload might belong on lower abstraction as IWeapon, time will tell
    void Reload();

}
