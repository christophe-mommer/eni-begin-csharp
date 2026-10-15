namespace DesktopWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object? sender, EventArgs e)
    {
        label1.Text = "Dernière fois que le bouton a été cliqué : " + DateTime.Now;
        MessageBox.Show("Vous avez cliqué sur le bouton");
    }
}
