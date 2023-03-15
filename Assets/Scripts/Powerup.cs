using UnityEngine;

public enum PowerupEnum
{
    FastBall,
    SlowBall,
    InvisiBall,
    SmallPaddle,
    BigPaddle,
    UnoReverse,
}

public class Powerup : MonoBehaviour
{
    public PowerupEnum PowerupType;
}
