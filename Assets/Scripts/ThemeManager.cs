using System;
using System.Collections.Generic;
using UnityEngine;

public class ThemeManager : MonoBehaviour
{
    public static ThemeManager Instance;
    [SerializeField] private List<ThemeSetting> themes;
    [SerializeField] private SpriteRenderer background;
    [SerializeField] private SpriteRenderer ball;
    [SerializeField] private SpriteRenderer leftPaddle;
    [SerializeField] private SpriteRenderer rightPaddle;
    [SerializeField] private SpriteRenderer fastPowerup;
    [SerializeField] private SpriteRenderer slowPowerup;
    [SerializeField] private SpriteRenderer invisiballPowerup;
    [SerializeField] private SpriteRenderer reversePowerup;
    [SerializeField] private SpriteRenderer growPowerup;
    [SerializeField] private SpriteRenderer shrinkPowerup;
    private int themeIndex = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            themeIndex = themes.FindIndex(t => t.Theme == LevelState.Instance.Theme);

            background.sprite = themes[themeIndex].Background;

            ball.sprite = themes[themeIndex].Ball;
            ball.gameObject.AddComponent<PolygonCollider2D>();

            leftPaddle.sprite = themes[themeIndex].LeftPaddle;
            leftPaddle.gameObject.AddComponent<PolygonCollider2D>();

            Instantiate(themes[themeIndex].CollisionEffect, leftPaddle.transform);
            leftPaddle.gameObject.GetComponent<Paddle>().GetParticleSystem(true);

            rightPaddle.sprite = themes[themeIndex].RightPaddle;
            rightPaddle.gameObject.AddComponent<PolygonCollider2D>();

            Instantiate(themes[themeIndex].CollisionEffect, rightPaddle.transform);
            rightPaddle.gameObject.GetComponent<Paddle>().GetParticleSystem(false);

            fastPowerup.sprite = themes[themeIndex].FastballPowerup;
            fastPowerup.gameObject.AddComponent<PolygonCollider2D>();
            fastPowerup.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

            slowPowerup.sprite = themes[themeIndex].SlowballPowerup;
            slowPowerup.gameObject.AddComponent<PolygonCollider2D>();
            slowPowerup.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

            invisiballPowerup.sprite = themes[themeIndex].InvisiballPowerup;
            invisiballPowerup.gameObject.AddComponent<PolygonCollider2D>();
            invisiballPowerup.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

            reversePowerup.sprite = themes[themeIndex].UnoReversePowerup;
            reversePowerup.gameObject.AddComponent<PolygonCollider2D>();
            reversePowerup.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

            growPowerup.sprite = themes[themeIndex].GrowPaddlePowerup;
            growPowerup.gameObject.AddComponent<PolygonCollider2D>();
            growPowerup.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

            shrinkPowerup.sprite = themes[themeIndex].ShrinkPaddlePowerup;
            shrinkPowerup.gameObject.AddComponent<PolygonCollider2D>();
            shrinkPowerup.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;

            Instantiate(themes[themeIndex].VolumePrefab, transform);

            SoundManager.Instance.PlayMusic(themes[themeIndex].Music);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public ThemeSetting Theme => themes[themeIndex];

    [Serializable]
    public class ThemeSetting
    {
        public Theme Theme;
        public Sprite Background;
        public Sprite Ball;
        public Sprite LeftPaddle;
        public Sprite RightPaddle;
        public Sprite FastballPowerup;
        public Sprite SlowballPowerup;
        public Sprite InvisiballPowerup;
        public Sprite UnoReversePowerup;
        public Sprite GrowPaddlePowerup;
        public Sprite ShrinkPaddlePowerup;
        public AudioClip PaddleHit;
        public AudioClip Goal;
        public AudioClip WallHit;
        public AudioClip Music;
        public AudioClip PowerupPickup;
        public GameObject VolumePrefab;
        public GameObject BallEffect;
        public GameObject GoalEffect;
        public GameObject CollisionEffect;
    }
}
