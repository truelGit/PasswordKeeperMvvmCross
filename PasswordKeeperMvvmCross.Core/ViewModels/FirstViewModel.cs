using MvvmCross.Core.ViewModels;

namespace PasswordKeeperMvvmCross.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		string hello = "Hello MvvmCross";
		public string Hello
		{
			get { return hello; }
			set { SetProperty(ref hello, value); }
		}
	}
}
