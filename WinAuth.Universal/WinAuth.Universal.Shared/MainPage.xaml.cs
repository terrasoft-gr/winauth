using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinAuth.Universal;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WinAuth.Universal
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();

			this.NavigationCacheMode = NavigationCacheMode.Required;
		}

		/// <summary>
		/// Invoked when this page is about to be displayed in a Frame.
		/// </summary>
		/// <param name="e">Event data that describes how this page was reached.
		/// This parameter is typically used to configure the page.</param>
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			// TODO: Prepare page for display here.

			// TODO: If your application contains multiple pages, ensure that you are
			// handling the hardware Back button by registering for the
			// Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
			// If you are using the NavigationHelper provided by some templates,
			// this event is handled for you.
		}

		private void AboutButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AboutForm));
		}

		private void AddAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddAuthenticator));
		}

		private void AddBattleNetAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddBattleNetAuthenticator));
		}

		private void AddGoogleAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddGoogleAuthenticator));
		}

		private void AddGuildWarsAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddGuildWarsAuthenticator));
		}

		private void AddMicrosoftAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddMicrosoftAuthenticator));
		}

		private void AddSteamAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddSteamAuthenticator));
		}

		private void AddTrionAuthenticatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(AddTrionAuthenticator));
		}

		private void BetaButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(BetaForm));
		}

		private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ChangePasswordForm));
		}

		private void DiagnosticButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(DiagnosticForm));
		}

		private void ExceptionButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ExceptionForm));
		}

		private void ExportButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ExportForm));
		}

		private void GetPasswordButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(GetPasswordForm));
		}

		private void GetPGPKeyButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(GetPGPKeyForm));
		}

		private void SetPasswordButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(SetPasswordForm));
		}

		private void ShowRestoreCodeButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ShowRestoreCodeForm));
		}

		private void ShowSecretKeyButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ShowSecretKeyForm));
		}

		private void ShowSteamSecretButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ShowSteamSecretForm));
		}

		private void ShowSteamTradesButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ShowSteamTradesForm));
		}

		private void ShowTrionSecretButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(ShowTrionSecretForm));
		}

		private void UnprotectPasswordButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(UnprotectPasswordForm));
		}

		private void UpdateCheckButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(UpdateCheckForm));
		}

		private void WinAuthButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(WinAuthForm));
		}

	}
}
