using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
	private readonly IApiAccess api = new ApiAccess();

	public Dashboard()
	{
		InitializeComponent();
		httpVerbSelection.SelectedItem = "GET";
	}

	private async void callAPI_Click(object sender, EventArgs e)
	{
		systemStatus.Text = "Calling API....";
		resultsText.Text = "";

		//validate API url
		if (api.IsValidUrl(apiText.Text) == false)
		{
			systemStatus.Text = "Invalid URL";
			return;
		}

		try
		{
			resultsText.Text = await api.CallApiAsync(apiText.Text);
			callData.SelectedTab = resultsTab;

			systemStatus.Text = "Ready";
		}
		catch (Exception ex)
		{
			resultsText.Text = "Error: " + ex.Message;
			systemStatus.Text = "Error";
		}
	}

	private void resultsLabel_Click(object sender, EventArgs e)
	{

	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{

	}

	private void formHeader_Click(object sender, EventArgs e)
	{

	}
}
