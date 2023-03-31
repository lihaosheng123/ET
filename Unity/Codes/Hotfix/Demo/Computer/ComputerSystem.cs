namespace ET
{
    public class CompuerAwakeSystem: AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("ComputerAwake!!");
        }
    }

    public class CompuerUpdateSystem: UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("computer update");
        }
    }

    public class ComputerDestorySystem: DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("computer Destroy");
        }
    }
    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("Computer Start");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();
        }
        
    }
}