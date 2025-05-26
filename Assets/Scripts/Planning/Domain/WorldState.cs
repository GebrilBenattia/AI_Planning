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

        public WorldStateData()
        {

        }

        public WorldStateData(WorldStateData other)
        {
            IsEnemyDead = other.IsEnemyDead;
            HasWeapon = other.HasWeapon;
            IsNearWeapon = other.IsNearWeapon;
            IsNearEnemy = other.IsNearEnemy;
            IsHurt = other.IsHurt;
        }
    }

    [System.Serializable]
    public class WorldState
    {
        public WorldStateData Data;

        public WorldState(WorldState other)
        {
            // Make a deep copy to avoid sharing references
            Data = new WorldStateData(other.Data); // Make sure WorldStateData also has a copy constructor!
        }
    }
}
