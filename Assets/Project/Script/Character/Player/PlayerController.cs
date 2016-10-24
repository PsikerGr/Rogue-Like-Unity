﻿using UnityEngine;
using System.Collections;

public class PlayerController : ACharacterController
{
    #region Delegates and events
    public delegate void DelegateAction();
    public event DelegateAction OnLeftDown;
    public event DelegateAction OnLeftUp;
    public event DelegateAction OnRightDown;
    #endregion

    Transform camTransform;

    protected void Start()
    {
        camTransform = FindObjectOfType<Cam>().transform;

        PlayerWeapons playerWeapons = transform.FindChild(GameManager.c_weaponChildName).GetComponent<PlayerWeapons>();
        if (playerWeapons == null)
            Debug.LogError("PlayerController.Start() - could not find child of name \"" + GameManager.c_weaponChildName + "\" of type PlayerWeapons");
        playerWeapons.SetController(this);
    }

    protected override void Update()
    {
        ResetTriggers();

        if (paused)
        {
            ControllerMove(0f, 0f);
            return;
        }

        UpdateInput();
    }

    private void UpdateInput()
    {
        #region Movement / Locomotion
        if (IsGrounded)
        {
            if (Input.GetButtonDown("Jump"))
                ControllerJump(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            else
                ControllerMove(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        ControllerCrouch(Input.GetButton("Crouch"));
        #endregion

        #region Magic
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetButtonDown("Magic " + i))
            {
                ControllerSelectMagic(i);
                break;
            }
        }

        if (Input.GetButtonDown("No Magic"))
            ControllerUnselectMagic();

        if (Input.GetButtonDown("CastSpell"))
            ControllerCastSpell();
        #endregion

        #region Hands actions
        if (Input.GetButtonDown("RightHand"))
            ControllerRightHand();

        if (Input.GetButtonDown("LeftHand"))
            ControllerLeftHand(true);
        else if (Input.GetButtonUp("LeftHand"))
            ControllerLeftHand(false);

        if (Input.GetButtonDown("SwitchWeapon"))
            ControllerDrawSheathSword();
        #endregion

        if (Input.GetButtonDown("Use"))
            ControllerUse();
    }

    #region Controller

    public override void ControllerRightHand()
    {
        base.ControllerRightHand();

        if (OnRightDown != null)
            OnRightDown.Invoke();
    }

    public override void ControllerLeftHand(bool bIsPressed = true)
    {
        base.ControllerLeftHand(bIsPressed);

        if (bIsPressed == true)
        {
            if (OnLeftDown != null)
                OnLeftDown.Invoke();
        }
        else
        {
            if (OnLeftUp != null)
                OnLeftUp.Invoke();
        }
    }

    public override void ControllerUse()
    {
        RaycastHit hit;
        // TODO: global(?) variable for max distance
        float useMaxDistance = 3f;
        if (Physics.Raycast(camTransform.position, camTransform.forward, out hit, useMaxDistance, ~(1 << LayerMask.NameToLayer("Player"))))
        {
            IUsableObject usableCollider = hit.collider.GetComponent<IUsableObject>();

            if (usableCollider != null)
            {
                usableCollider.OnUse(character);
            }
        }
    }

    #endregion

}