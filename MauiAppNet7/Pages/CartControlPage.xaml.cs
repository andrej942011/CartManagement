using System.Diagnostics;

namespace MauiAppNet7.Pages;

public partial class CartControlPage : ContentPage
{
	public CartControlPage()
	{
		InitializeComponent();

        CurrentTime = "00:00:00";

        int num = 0;
        // устанавливаем метод обратного вызова
        TimerCallback tm = new TimerCallback(Callback);
        // создаем таймер
        Timer timer = new Timer(tm, num, 0, 1000);
    }

    public string CurrentTime { get; set; }

    private void Callback(object state)
    {
        CurrentTime = DateTime.Now.ToString("T");
        Debug.WriteLine(DateTime.Now);
    }
}