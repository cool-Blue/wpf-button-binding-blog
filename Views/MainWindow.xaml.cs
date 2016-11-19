using System.Collections.Generic;
using System.Windows;
using ButtonBindingMinimal.ViewModels;

namespace ButtonBindingMinimal.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public StaticButton Button { get; set; }
		public StaticButton Remote { get; set; }
		public MainWindow ()
		{
			InitializeComponent();
			Button = new StaticButton(new List<string> { "Checked State", "UnChecked State" }, true);
			Remote = new StaticButton(new List<string> { "", "Remote" }, false);

			// build the view model and connect it to the view
			DataContext = new ViewModel(target);
		}
	}
}
