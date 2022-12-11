namespace CalculatorMAUI;

public partial class MainPage : ContentPage
{

	double premierChiffre = 0;
    double deuxiemeChiffre = 0;
    string operatorArithmetique = string.Empty;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button myButton = (Button)sender;

		string myText = myButton.Text;

		if (this.lblResult.Text == "0")
            this.lblResult.Text = myText;
		else
			this.lblResult.Text += myText;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Button myButton = (Button)sender;

        string myText = myButton.Text;

		operatorArithmetique = myText;

        premierChiffre = Convert.ToDouble(lblResult.Text);

        this.lblResult.Text = "0";
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

        double resultatFinal = 0;
        
        deuxiemeChiffre = Convert.ToDouble(lblResult.Text);

        //on calcule
        switch (operatorArithmetique)
        {
            case "+":
                resultatFinal = premierChiffre + deuxiemeChiffre;
                break;

            case "-":
                resultatFinal = premierChiffre - deuxiemeChiffre;
                break;

            case "/":
                resultatFinal = premierChiffre / deuxiemeChiffre;
                break;

            case "*":
                resultatFinal = premierChiffre * deuxiemeChiffre;
                break;

            default:
                break;
        }

        this.lblResult.Text = resultatFinal.ToString();

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        this.lblResult.Text = "0";
        premierChiffre = 0;
        deuxiemeChiffre = 0;
        operatorArithmetique = string.Empty;
    }
}

