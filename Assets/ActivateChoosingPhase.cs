using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateChoosingPhase : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameManager.Instance.choosingPhase.SetActive(true);
        GameManager.Instance.startingScreen.SetActive(false);

        GameManager.Instance.player1.input.SwitchCurrentActionMap("SelectionPart");
        GameManager.Instance.player2.input.SwitchCurrentActionMap("SelectionPart");
        
        GameManager.Instance.player1.UpdateObjectSelection();
        GameManager.Instance.player2.UpdateObjectSelection();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameManager.Instance.player1.input.SwitchCurrentActionMap("SelectionPart");
        GameManager.Instance.player2.input.SwitchCurrentActionMap("SelectionPart");
        
        GameManager.Instance.player1.selectedX = GameManager.Instance.player1.selectedY =
            GameManager.Instance.player2.selectedX = GameManager.Instance.player2.selectedY = 0;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
