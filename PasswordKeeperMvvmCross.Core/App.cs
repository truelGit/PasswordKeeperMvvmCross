using MvvmCross.Platform.IoC;

namespace PasswordKeeperMvvmCross.Core
{
	public class App : MvvmCross.Core.ViewModels.MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
		}
	}
}
