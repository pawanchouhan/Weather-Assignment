app.service('weatherService', function ($http) {    

    this.getCitiesList = function (country) {
        var getRequest = $http({
            method: "get",
            url: "/Weather/" + country
        });

        return getRequest;
    };

    this.getWeatherInformation = function (country, city) {
        var getRequest = $http({
            method: "get",
            url: "http://api.openweathermap.org/data/2.5/weather?appid=6a478602978a5f4ebba7a84cfc5eda63&q=" + country + "," + city
        });

        return getRequest;
    };

});