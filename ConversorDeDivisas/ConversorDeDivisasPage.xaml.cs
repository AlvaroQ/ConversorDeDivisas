using Xamarin.Forms;

namespace ConversorDeDivisas
{
	public partial class ConversorDeDivisasPage : ContentPage
	{
		public ConversorDeDivisasPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(eurosEntry.Text))
			{
				labelInfo.Text = "Introduzca una cantidad en euros";
				eurosEntry.Focus();
				return;
			}

			textLibras.IsVisible = true;
			textDolares.IsVisible = true;

			decimal euros = decimal.Parse(eurosEntry.Text);
			textLibras.Text = string.Format("{0:N2}", Conversion.ToLibras(euros)) + " libras";
			textDolares.Text = string.Format("{0:N2}", Conversion.ToDolares(euros)) + " dolares";

		}
	}
}

