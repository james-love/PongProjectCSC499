using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    private void Awake()
    {
        PlayerInput input = GetComponent<PlayerInput>();

        input.actions.FindAction("Players/Pause").Enable();

#if UNITY_EDITOR
        if (LevelState.Instance != null && LevelState.Instance.Players == Players.OnePlayer)
#else
        if (LevelState.Instance.Players == Players.OnePlayer)
#endif
        {
            input.actions.FindAction("Players/LeftPlayerMove").Enable();
            input.actions.FindAction("Players/RightPlayerMove").Disable();
        }
        else
        {
            input.actions.FindAction("Players/LeftPlayerMove").Enable();
            input.actions.FindAction("Players/RightPlayerMove").Enable();
        }
    }
}
