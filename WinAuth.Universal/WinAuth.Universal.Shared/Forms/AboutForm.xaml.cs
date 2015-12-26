using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinAuth.Universal.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WinAuth.Universal
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class AboutForm : Page
	{
		private NavigationHelper navigationHelper;
		private ObservableDictionary defaultViewModel = new ObservableDictionary();

		public AboutForm()
		{
			this.InitializeComponent();
			this.navigationHelper = new NavigationHelper(this);
			this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
		}

		/// <summary>
		/// Gets the NavigationHelper used to aid in navigation and process lifetime management.
		/// </summary>
		public NavigationHelper NavigationHelper => this.navigationHelper;

		/// <summary>
		/// Populates the page with content passed during navigation.  Any saved state is also
		/// provided when recreating a page from a prior session.
		/// </summary>
		/// <param name="sender">
		/// The source of the event; typically <see cref="NavigationHelper"/>
		/// </param>
		/// <param name="e">Event data that provides both the navigation parameter passed to
		/// <see cref="Frame.Navigate(Type, object)"/> when this page was initially requested and
		/// a dictionary of state preserved by this page during an earlier
		/// session.  The state will be null the first time a page is visited.</param>
		private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
		{
			// TODO: Create an appropriate data model for your problem domain to replace the sample data
			//var item = await SampleDataSource.GetItemAsync((string)e.NavigationParameter);
			//this.DefaultViewModel["Item"] = item;
		}

		private void closeButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.GoBack();
		}

		private void UpdateVersion()
		{
			// get the version of the application
			Version version = this.GetType().GetTypeInfo().Assembly.GetName().Version;
			string debug = string.Empty;
#if BETA
            debug += " (BETA)";
#endif
#if DEBUG
			debug += " (DEBUG)";
#endif
			this.AboutLabel.Text = string.Format(this.AboutLabel.Text, version.ToString(3) + debug);
			// TODO: Fix copyright year.
			// Copyright doesn't really work this way. It should be calculated at each compilation
			this.CopyrightLabel.Text = string.Format(this.CopyrightLabel.Text, DateTime.Today.Year);

		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			UpdateVersion();
			LoadResourceText();
		}

		private async void LoadResourceText()
		{
			await FillRichTextBoxFromFile(this.LicenseText, "GPL3.txt");
			await FillRichTextBoxFromFile(this.TrademarksText, "Trademarks.txt");
		}

		private static async Task FillRichTextBoxFromFile(RichTextBlock outputControl, string textFile)
		{
			string resourceText;
			var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(@"ms-appx:///Resources/" + textFile));

			using (var stream = (await file.OpenReadAsync()).AsStreamForRead())
			using (var reader = new StreamReader(stream, Encoding.UTF8))
				resourceText = reader.ReadToEnd();

			foreach (var paragraphText in resourceText.Split('\r', '\n'))
			{
				var paragraph = new Paragraph();
				paragraph.Inlines.Add(new Run { Text = paragraphText });
				outputControl.Blocks.Add(paragraph);
			}
		}

		private void ReportButton_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
