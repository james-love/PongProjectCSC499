using System.Collections;
using UnityEngine;

public class PowerupEffect : MonoBehaviour
{
    public PowerupEnum PowerupType { get; set; }

    public static void GenerateEffect(PowerupEnum type, GameObject ball, GameObject paddle)
    {
        PowerupEffect newEffect = null;
        switch (type)
        {
            case PowerupEnum.FastBall:
            case PowerupEnum.SlowBall:
            case PowerupEnum.InvisiBall:
                newEffect = ball.AddComponent<PowerupEffect>();
                newEffect.PowerupType = type;
                break;
            case PowerupEnum.SmallPaddle:
            case PowerupEnum.BigPaddle:
                newEffect = paddle.AddComponent<PowerupEffect>();
                newEffect.PowerupType = type;
                break;
            case PowerupEnum.UnoReverse:
                ball.GetComponent<Ball>().UnoReverse();
                break;
            default:
                break;
        }

        if (newEffect != null)
            newEffect.StartEffect();
    }

    public void StartEffect()
    {
        switch (PowerupType)
        {
            case PowerupEnum.FastBall:
                GetComponent<Ball>().Speed *= 3f;
                break;
            case PowerupEnum.SlowBall:
                GetComponent<Ball>().Speed /= 3f;
                break;
            case PowerupEnum.InvisiBall:
                GetComponent<SpriteRenderer>().enabled = false;
                break;
            case PowerupEnum.SmallPaddle:
                transform.localScale = new Vector3(1f, 0.5f, 1f);
                break;
            case PowerupEnum.BigPaddle:
                transform.localScale = new Vector3(1f, 1.5f, 1f);
                break;
            default:
                break;
        }

        StartCoroutine(StopEffect());
    }

    private IEnumerator StopEffect()
    {
        yield return new WaitForSeconds(15f);

        switch (PowerupType)
        {
            case PowerupEnum.FastBall:
            case PowerupEnum.SlowBall:
                GetComponent<Ball>().Speed = 4f;
                break;
            case PowerupEnum.InvisiBall:
                GetComponent<SpriteRenderer>().enabled = true;
                break;
            case PowerupEnum.SmallPaddle:
            case PowerupEnum.BigPaddle:
                transform.localScale = Vector3.one;
                break;
            default:
                break;
        }

        Destroy(this);
    }
}
