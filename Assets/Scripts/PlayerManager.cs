using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IP
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator animator;
        CameraHandler cameraHandler;
        Player player;


        public bool isInteracting;

        public bool inAir;
        public bool isGrounded;


        private void Awake()
        {
            cameraHandler = FindObjectOfType<CameraHandler>();
        }


        // Start is called before the first frame update
        void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            animator = GetComponentInChildren<Animator>();
            player = GetComponent<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            float delta = Time.deltaTime;

            isInteracting = animator.GetBool("isInteracting");

            inputHandler.TickInput(delta);
            player.HandleMovement(delta);
            player.HandleRollAndSprint(delta);
            player.HandleFalling(delta, player.moveDirection);
        }
        private void FixedUpdate()
        {
            float delta = Time.deltaTime;

            if (cameraHandler != null)
            {
                cameraHandler.FollowTarget(delta);
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }
        }

        private void LateUpdate()
        {
            inputHandler.rollFlag = false;
            inputHandler.LightAttack_Input = false;
            inputHandler.HeavyAttack_Input = false;
            inputHandler.pauseInput = false;

            if (inAir)
            {
                player.airTimer = player.airTimer + Time.deltaTime;
            }
        }

    }
}