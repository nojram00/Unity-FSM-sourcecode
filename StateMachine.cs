using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine{
    IState currentlyState;
    IState previousState;

    public void changeState(IState newState){
        if(this.currentlyState != null){
            this.currentlyState.Exit();
        }
        var x = this.currentlyState;
        this.currentlyState  = newState;
        this.previousState = x;
    }
    public void Execute(){
        if(this.currentlyState != null){
            this.currentlyState.Execute();
        }
    }
    public void switchToPreviousState(){
        changeState(this.previousState);
    }
}
