﻿using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorDemo.Pages
{
    public partial class FetchData3
    {
        private WeatherForecast[]? forecasts;

        [Inject] 
        public HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string? Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
