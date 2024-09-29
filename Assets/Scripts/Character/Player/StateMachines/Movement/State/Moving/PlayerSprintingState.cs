using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectGaryn
{
    public class PlayerSprintingState : PlayerGroundedState
    {
        public PlayerSprintingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }
    }
}
