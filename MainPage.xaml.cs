using ExamenProgreso3API_ThyaraVintimilla.TV_Models;
using System.Net;
using SQLite;
using Newtonsoft.Json;

namespace ExamenProgreso3API_ThyaraVintimilla;

public partial class MainPage : ContentPage
{
    private SQLiteConnection _connection;

    public MainPage()
    {
        InitializeComponent();
        //_connection = DependencyService.Get<ISQLite>().GetConnection();
        //_connection.CreateTable<TV_Root>();
    }
    public async void Button_Clicked(object sender, EventArgs e)
    {
        string cadena = Buscador.Text;
        var request = new HttpRequestMessage();
        //request.RequestUri = new Uri("https://documenter.getpostman.com/view/10808728/SzS8rjbc#00030720-fae3-4c72-8aea-ad01ba17adf8");
        request.RequestUri = new Uri("https://api.dictionaryapi.dev/api/v2/entries/en/" + cadena);
        request.Method = HttpMethod.Get;
        request.Headers.Add("Accept", "application/json");

        var client = new HttpClient();

        HttpResponseMessage response = await client.SendAsync(request);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            String content = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<List<TV_Root>>(content);
            ListaDemo.ItemsSource = resultado;
        }
        //var busqueda = new TV_Root { word = entry.Text };
        // _connection.Insert(busqueda);
    }

}

