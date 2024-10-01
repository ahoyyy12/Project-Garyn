using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectGaryn
{
    [RequireComponent(typeof(PlayerInput))]
    public class Player : MonoBehaviour
    {
        [field: Header("Reference")]
        [field: SerializeField] public PlayerSO Data {  get; private set; }
        public Rigidbody Rigidbody {  get; private set; }

        public Transform MainCameraTransform { get; private set; }
        public PlayerInput Input { get; private set; }

        private PlayerMovementStateMachine movementStateMachine;

        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
            Input = GetComponent<PlayerInput>();

            MainCameraTransform = Camera.main.transform;

            movementStateMachine = new PlayerMovementStateMachine(this);
        }

        private void Start()
        {
            movementStateMachine.ChangeState(movementStateMachine.idlingState);
        }

        private void Update()
        {
            movementStateMachine.HandleInput();
            movementStateMachine.Update();
        }

        private void FixedUpdate()
        {
            movementStateMachine.PhysicsUpdate();
        }
    }
}
 