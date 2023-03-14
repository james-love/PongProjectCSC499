using System;
using System.Collections.Generic;
using UnityEngine;

public class ThemeManager : MonoBehaviour
{
    public static ThemeManager Instance;
    [SerializeField] private List<ThemeSetting> themes;
    [SerializeField] private SpriteRenderer background;
    private int themeIndex = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            themeIndex = themes.FindIndex(t => t.Theme == LevelState.Instance.Theme);

            background.sprite = themes[themeIndex].Background;
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
    }
}
