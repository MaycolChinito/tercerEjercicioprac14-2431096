namespace tercerEjercicio;

//<Summary>
//<Createddate>10/7/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>10/7/2023</lastmodificationdate>
///<lastmodificationdescription>
///creo el programa para calcular 
///el promedio de la calificacion de un alumno
///</lastmodificationdescription>
//////<lastmodifierautor>Maycol Barrera</lastmodifierautor>
//</Summary>

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double nume1 = Convert.ToDouble(num1.Text);
        double nume2 = Convert.ToDouble(num2.Text);
        double nume3 = Convert.ToDouble(num3.Text);
        double nume4 = Convert.ToDouble(num4.Text); 
		double nume5 = Convert.ToDouble(num5.Text);
		double r = nume1 + nume2 + nume3 + nume4 + nume5 /5;
	



		Respuesta.Text = Convert.ToString(r);
    }

  
}

