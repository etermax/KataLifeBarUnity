using System;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarView : MonoBehaviour
{
    [SerializeField] private Button _attackButton;
    [SerializeField] private TMP_InputField _attackValue;
    [SerializeField] private Button _healButton;
    [SerializeField] private TMP_InputField _healValue;

    [SerializeField] private Slider _lifeBar;
    
    private Life _life;

    private void Awake()
    {
        _life = new Life();
        _lifeBar.value = _life.CurrentValue;
    }
    
    private void Start()
    {
        _attackButton.onClick.AddListener(TakeDamage);
        _healButton.onClick.AddListener(TakeHeal);
    }

    private void TakeHeal()
    {
        var healValue = _healValue.text;
        _life.ReceiveHeal(Int32.Parse(healValue));
        _lifeBar.value = _life.CurrentValue;
    }
    
    private void TakeDamage()
    {
        var damageValue = _attackValue.text;
        _life.ReceiveDamage(Int32.Parse(damageValue));
        _lifeBar.value = _life.CurrentValue;
    }
}
