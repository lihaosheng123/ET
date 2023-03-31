﻿using UnityEngine;

namespace ET
{
    public class AfterUnitCreate_CreateUnitView: AEvent<EventType.AfterUnitCreate>
    {
        protected override void Run(EventType.AfterUnitCreate args)
        {
            switch (args.Unit.UnitType)
            {
                case UnitType.Player:
                {
                    // Unit View层
                    // 这里可以改成异步加载，demo就不搞了
                    GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
                    GameObject prefab = bundleGameObject.Get<GameObject>("Skeleton");
	        
                    GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
                    go.transform.position = args.Unit.Position;
                    args.Unit.AddComponent<GameObjectComponent>().GameObject = go;
                    args.Unit.AddComponent<AnimatorComponent>();
                }
                    break;

                case UnitType.NPC:
                {
                    // Unit View层
                    // 这里可以改成异步加载，demo就不搞了
                    GameObject bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
                    GameObject prefab = bundleGameObject.Get<GameObject>("Skeleton");
	        
                    GameObject go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
                    go.transform.position = args.Unit.Position;
                    args.Unit.AddComponent<GameObjectComponent>().GameObject = go;
                    args.Unit.AddComponent<AnimatorComponent>();
                }
                    
                    break;
            }
            
        }
    }
}