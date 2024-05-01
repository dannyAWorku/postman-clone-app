namespace PostmanClone.UI;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void btnCallAPI_Click(object sender, EventArgs e)
    {
        try
        {
            lblSystemStatus.Text = "Calling API...";

            lblSystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
