using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int playerIndex = 0;
    private PlayerInputManager inputManager;

    public Animator animator;

    private static readonly int PlayerCount = Animator.StringToHash("PlayerCount");

    public GameObject choosingPhase;
    public GameObject fightingPhase;

    public PlayerManager player1;
    public PlayerManager player2;

    public Wallet wallet1;
    public Wallet wallet2;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        animator = GetComponent<Animator>();
        
        inputManager = GetComponent<PlayerInputManager>();
        inputManager.onPlayerJoined += InputManagerOnonPlayerJoined;
    }

    private void InputManagerOnonPlayerJoined(PlayerInput obj)
    {
        print("ga");
        if (playerIndex == 0)
        {
            player1 = obj.GetComponent<PlayerManager>();
            player1.wallet = wallet1;
        }
        else
        {
            player2 = obj.GetComponent<PlayerManager>();
            player2.wallet = wallet2;
        }
        
        obj.GetComponent<PlayerManager>().playerIndex = playerIndex;
        playerIndex++;
        
        animator.SetInteger(PlayerCount, playerIndex);
    }
}
