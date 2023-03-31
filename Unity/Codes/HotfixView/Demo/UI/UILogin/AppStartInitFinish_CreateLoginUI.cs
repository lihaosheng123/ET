

namespace ET
{
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async void Run(EventType.AppStartInitFinish args)
		{
			 UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();
			
			Log.Debug("aaaaaaaaaa");
			//TestAsync().Coroutine();
		//	this.TestAsync().Coroutine();
		int reslut = await this.TestResultAsync();
		Log.Debug(reslut.ToString());
			Log.Debug("bbbbbbbb");
		}

		public async ETTask TestAsync()
		{
			Log.Debug("11111111111111");
			await TimerComponent.Instance.WaitAsync(2000);
			Log.Debug("2222222222222");
		}

		public async ETTask<int> TestResultAsync()
		{
			Log.Debug("11111111111111");
			await TimerComponent.Instance.WaitAsync(2000);
			Log.Debug("2222222222222");

			return 10;
		}
		
	}
}
