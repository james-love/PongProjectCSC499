using System.Collections;
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
    private int speedBuff = 5;


    public void Effect(GameObject ball, GameObject lastHitPaddle)
    {

        Ball ballComponent = ball.GetComponent<Ball>();
        SpriteRenderer ballRenderer = ball.GetComponent<SpriteRenderer>();

        switch (PowerupType)
        {
            case PowerupEnum.FastBall:
                print("fastball");
                // call fastball function
                FastballEnable(ballComponent);
                break;
            case PowerupEnum.SlowBall:
                print("slowball");
                // call slowball function, and so on
                SlowballEnable(ballComponent);
                break;
            case PowerupEnum.InvisiBall:
                print("invisiball");
                break;
            case PowerupEnum.SmallPaddle:
                print("small paddle");
                break;
            case PowerupEnum.BigPaddle:
                print("big paddle");
                break;
            case PowerupEnum.UnoReverse:
                print("uno reverse");
                break;
            default:
                break;
        }
    }

    void FastballEnable(Ball ballComponent)
    {
    
        ballComponent.Speed *= speedBuff;

        //StartCoroutine(FastballDisable(ballComponent));
    }

        void SlowballEnable(Ball ballComponent)
    {
        
        ballComponent.Speed /= speedBuff;

        //StartCoroutine(SlowballDisable(ballComponent));
    }
    
    //void Invisiball()

    //void SmallPaddle()

    //void BigPaddle()

    //void UnoReverse()

    IEnumerator FastballDisable(Ball ballComponent)
    {
        print("before yield");
        yield return new WaitForSeconds(5.0f); // powerup will last for 5 seconds
        print("after yield");

        ballComponent.Speed /= speedBuff;
    }

    IEnumerator SlowballDisable(Ball ballComponent)
    {
        yield return new WaitForSeconds(5.0f); 

        ballComponent.Speed *= speedBuff;
    }

    

}
