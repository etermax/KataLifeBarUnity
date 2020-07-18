using UnityEngine;

namespace Core
{
    public class Life 
    {
        private const int MAX_VALUE = 100;
        private const int MIN_VALUE = 0;
        private const int SPECIAL_HEAL = 50;

        public int CurrentValue = MAX_VALUE;

        private bool _hasShield;

        public void ReceiveDamage(int amount)
        {
            if (_hasShield)
            {
                _hasShield = false;
                return;
            }
            
            CurrentValue = Mathf.Max(MIN_VALUE, CurrentValue - amount);
        }

        public void ReceiveHeal(int amount)
        {
            if (CurrentValue >= MAX_VALUE)
                return;
            
            CurrentValue = Mathf.Min(MAX_VALUE, CurrentValue + amount);
        }
        
        public void ReceiveShield()
        {
            _hasShield = true;
        }
        
        public void ReceiveSpecialHeal()
        {
            CurrentValue += SPECIAL_HEAL;
        }
    }
}