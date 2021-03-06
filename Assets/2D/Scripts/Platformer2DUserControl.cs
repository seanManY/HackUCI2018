using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

        private bool dash;
        private int maxDash   = 5;
        private int dashCount = 0;
        

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");

                

            }

            if (!dash)
            {
                dash = CrossPlatformInputManager.GetButtonDown("Fire1");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetAxis("Vertical") < 0;
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump, dash);
            if(dash && (dashCount < maxDash))
            {
                dashCount++;
            }
            else
            {
                dash = false;
                dashCount = 0;
            }
            
            m_Jump = false;
        }
    }
}
