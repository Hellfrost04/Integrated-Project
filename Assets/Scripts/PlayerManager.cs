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
        PlayerStats playerStats;


        public bool isInteracting;

        public bool inAir;
        public bool isGrounded;
        public bool isInvulnerable;


        private void Awake()
        {
            cameraHandler = FindObjectOfType<CameraHandler>();
            playerStats = GetComponent<PlayerStats>();
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
            if(playerStats.isDead == true)
            {
                isInteracting = true;
                inputHandler.LightAttack_Input = false;
                inputHandler.HeavyAttack_Input = false;
            }

            float delta = Time.deltaTime;

            isInteracting = animator.GetBool("isInteracting");

            inputHandler.TickInput(delta);

            player.HandleRollAndSprint(delta);

            isInvulnerable = animator.GetBool("isInvulnerable");
        }

        private void FixedUpdate()
        {
            float delta = Time.deltaTime;
            player.HandleMovement(delta);
            player.HandleFalling(delta, player.moveDirection);
        }

        private void LateUpdate()
        {
            inputHandler.rollFlag = false;
            inputHandler.LightAttack_Input = false;
            inputHandler.HeavyAttack_Input = false;
            inputHandler.pauseInput = false;

            float delta = Time.deltaTime;

            if (cameraHandler != null)
            {
                cameraHandler.FollowTarget(delta);
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }

            if (inAir)
            {
                player.airTimer = player.airTimer + Time.deltaTime;
            }
        }

    }
}