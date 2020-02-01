using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float roundDuration;
    public float timer;
    public bool isSelectingRound;

    public TextMeshProUGUI timerText;
    
    public static GameManager Instance;
    public int playerIndex = 0;
    private PlayerInputManager inputManager;

    public Animator animator;

    private static readonly int PlayerCount = Animator.StringToHash("PlayerCount");

    public GameObject choosingPhase;
    public GameObject fightingPhase;

    public PlayerManager player1;
    public PlayerFight player1Fight;
    
    public PlayerManager player2;
    public PlayerFight player2Fight;

    public Wallet wallet1;
    public Wallet wallet2;

    public GameObject robotPlayer1;
    public GameObject robotPlayer2;

    public Slider healthPlayer1;
    public Slider healthPlayer2;
    
    private static readonly int FightPhase = Animator.StringToHash("FightPhase");

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
        if (playerIndex == 0)
        {
            player1Fight = obj.GetComponent<PlayerFight>();
            player1Fight.playerIndex = playerIndex;
            player1Fight.healthBar = healthPlayer1;
            
            player1 = obj.GetComponent<PlayerManager>();
            player1.wallet = wallet1;
            obj.GetComponent<PlayerFight>().robot = robotPlayer1;
            robotPlayer1.GetComponent<Robot>().player = player1Fight;
        }
        else
        {
            player2Fight = obj.GetComponent<PlayerFight>();
            player2Fight.playerIndex = playerIndex;
            player2Fight.healthBar = healthPlayer2;
            
            player2 = obj.GetComponent<PlayerManager>();
            player2.wallet = wallet2;
            obj.GetComponent<PlayerFight>().robot = robotPlayer2;
            robotPlayer2.GetComponent<Robot>().player = player2Fight;
        }
        
        obj.GetComponent<PlayerManager>().playerIndex = playerIndex;
        playerIndex++;
        
        animator.SetInteger(PlayerCount, playerIndex);
    }

    private void Update()
    {
        if (isSelectingRound)
        {
            timer += Time.deltaTime;

            timerText.text = (roundDuration - timer).ToString("F");

            if (timer >= roundDuration)
            {
                animator.SetTrigger(FightPhase);
                isSelectingRound = false;
            }
                
        }
    }

    public void StartTimerForSelection()
    {
        timer = 0;
        isSelectingRound = true;
    }

    public void PlayerDie(int player)
    {
        if (player == 1)
        {
            print("The player 1 dies");
        }
        else
        {
            print("The player 2 dies");
        }
    }
}
