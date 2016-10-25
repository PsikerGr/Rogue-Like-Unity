﻿using UnityEngine;

public class ACharacterWeapons : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    private GameObject leftHandAnchor = null;

    [SerializeField]
    private GameObject rightHandAnchor = null;
    #endregion

    private ACharacterController controller = null;

    private WeaponAnchor leftHand = null;
    private WeaponAnchor rightHand = null;

    private MagicManager.MagicID magicID = MagicManager.MagicID.NONE;
    public MagicManager.MagicID ActiveMagic { get { return magicID; } }
    private AMagic magic = null;

    // Use this for initialization
    private void Start()
    {
        if (leftHandAnchor == null || rightHandAnchor == null)
            Debug.LogError("ACharacterWeapons.Start() - leftHandAnchor and rightHandAnchor should be initialized.");

        leftHand = leftHandAnchor.AddComponent<WeaponAnchor>();
        if (leftHand == null)
            Debug.LogError("ACharacterWeapons.Start() - couldn't get component of type WeaponAnchor in leftHandAnchor");

        rightHand = rightHandAnchor.AddComponent<WeaponAnchor>();
        if (rightHand == null)
            Debug.LogError("ACharacterWeapons.Start() - couldn't get component of type WeaponAnchor in rightHandAnchor");

        leftHand.SetWeapon(ItemManager.Instance.CreateObject<Shield>());
        rightHand.SetWeapon(ItemManager.Instance.CreateObject<Sword>());
    }

    public void SetCharacter(ACharacter _character)
    {
        _character.OnChangedWeapons += SetWeapons;
    }

    public void SetController(ACharacterController characterController)
    {
        controller = characterController;

        Animator characterAnimator = characterController.GetComponent<Animator>();
        if (characterAnimator == null)
            Debug.LogError("ACharacterWeapons.SetController() - couldn't get component of type Animator in ACharacterController");

        CharacterSwitchWeapon[] characterSwitchBehaviour = characterAnimator.GetBehaviours<CharacterSwitchWeapon>();
        if (characterSwitchBehaviour == null)
            Debug.LogError("ACharacterWeapons.SetController() - couldn't get behaviours of type CharacterSwitchWeapon in characterAnimator");
        foreach (CharacterSwitchWeapon oneCharSwitchBehaviour in characterSwitchBehaviour)
            oneCharSwitchBehaviour.OnSwitch += SwitchWeapon;
    }

    private void SetWeapons(Item leftWeapon, Item rightWeapon)
    {
        leftHand.SetWeapon(leftWeapon);
        rightHand.SetWeapon(rightWeapon);
    }

    private void SwitchWeapon()
    {
        leftHand.Switch();
        rightHand.Switch();
    }

    public void InstanciateMagic()
    {
        if (magic != null)
            return;
        if (magicID != MagicManager.MagicID.NONE)
        {
            magic = MagicManager.Instance.CreateSpell(magicID, controller);
            magic.gameObject.transform.parent = rightHandAnchor.transform;
            magic.gameObject.transform.localPosition = Vector3.zero;
        }
    }

    public void ActivateMagic()
    {
        if (magic != null)
        {
            magic.Activate();
            magic = null;
        }
        else
            Debug.LogWarning("ACharacterWeapon.ActivateMagic() - member \"magic\" is null");
    }

    public void SetActiveMagic(MagicManager.MagicID id)
    {
        magicID = id;
    }
}