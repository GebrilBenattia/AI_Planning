namespace Planning.Domain
{
    [System.Serializable]
    public class WorldStateData
    {
        public bool IsEnemyDead = false;
        public bool HasWeapon = false;
        public bool IsNearWeapon = false;
        public bool IsNearEnemy = false;
        public bool IsHurt = false;
    }

    [System.Serializable]
    public class WorldState
    {
        public WorldStateData Data;
    }
}
