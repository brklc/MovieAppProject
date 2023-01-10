using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using MovieProject.Business.Services.Abstract;
using MovieProject.Business.Services.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json;

namespace MovieProject.Business.Services.Concrate
{
    public class BackgroundServices : BackgroundService
    {
        private readonly IConfiguration _config;
        private HttpClient _httpClient;
        private readonly IMovieService _movieService;

        public BackgroundServices(IConfiguration configuration, IMovieService movieService)
        {
            _config = configuration;
            _movieService = movieService;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _httpClient = new HttpClient();
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _config["MovieApi:AccessTokenForMovieApi"]);
                var response = await _httpClient.GetAsync(_config["MovieApi:ApiUrl"]);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var data = await response.Content.ReadAsStringAsync();

                    await _movieService.Post(JsonConvert.DeserializeObject<MovieModel>(data));

                }


                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }
        }


        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
