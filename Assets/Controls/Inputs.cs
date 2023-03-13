using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    [SerializeField] private MovePaddle playerOne;
    [SerializeField] private MovePaddle playerTwo;
    private LevelState state;
    private void Awake()
    {
#if UNITY_EDITOR
        GameObject levelStateObject = GameObject.Find("LevelState");
        if (levelStateObject != null)
        {
            state = levelStateObject.GetComponent<LevelState>();
        }
        else
        {
            print("LevelState not found!");
            state = new LevelState();
            state.PlayersChanged(Players.OnePlayer);
        }
#else
        state = GameObject.Find("LevelState").GetComponent<LevelState>();
#endif

        PlayerInput input = GetComponent<PlayerInput>();
        if (state.Players == Players.OnePlayer)
        {
            input.actions.FindActionMap("SinglePlayer").Enable();
            input.actions.FindActionMap("TwoPlayer").Disable();

            input.actions.FindAction("Move").performed += playerOne.Move;
            input.actions.FindAction("Move").canceled += playerOne.Stop;
        }
        else
        {
            input.actions.FindActionMap("SinglePlayer").Disable();
            input.actions.FindActionMap("TwoPlayer").Enable();

            input.actions.FindAction("LeftPlayerMove").performed += playerOne.Move;
            input.actions.FindAction("LeftPlayerMove").canceled += playerOne.Stop;

            input.actions.FindAction("RightPlayerMove").performed += playerTwo.Move;
            input.actions.FindAction("RightPlayerMove").canceled += playerTwo.Stop;
        }
    }
}
