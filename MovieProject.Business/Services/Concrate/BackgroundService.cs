using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider _serviceProvider;

        public BackgroundServices(IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _config = configuration;
            _serviceProvider = serviceProvider;
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

                    using (IServiceScope scope = _serviceProvider.CreateScope())
                    {
                        IMovieService mov =
                            scope.ServiceProvider.GetRequiredService<IMovieService>();

                        await mov.Post(JsonConvert.DeserializeObject<MovieModel>(data));
                    }

                   // await _movieService.Post(JsonConvert.DeserializeObject<MovieModel>(data));

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
