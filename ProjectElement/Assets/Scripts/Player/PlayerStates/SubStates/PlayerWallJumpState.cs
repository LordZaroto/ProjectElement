using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallJumpState : PlayerAbilityState
{
    public PlayerWallJumpState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animName) : base(player, stateMachine, playerData, animName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        player.Flip();
        player.SetVelocityX(playerData.wallJumpVelocityX * player.FacingDirection);
        player.SetVelocityY(playerData.wallJumpVelocityY);
        isAbilityDone = true;
    }
}
