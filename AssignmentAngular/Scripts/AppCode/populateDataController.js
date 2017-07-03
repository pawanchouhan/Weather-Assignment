app.controller('populateDataController', function ($scope, weatherService) {  
    

    $scope.CountryName = "";
    $scope.SelectedCity = "";
    $scope.ShowWeather = false;
    $scope.Message = "";

    //Method to get the cities  data
    function loadRecords() {
        var promiseGet = weatherService.getCitiesList($scope.CountryName); //The method to call from service

        promiseGet.then(function (pl) {
            if (pl.data.NewDataSet != null) {
                $scope.Cities = pl.data.NewDataSet.Table;
                $scope.Message = "";
            }
            else {
                $scope.Message = "Please enter a valid country name"
            }

        },
            function (errorPl) {
                $log.error('failure loading Cities', errorPl);
            });
    }

    $scope.PopulateCities = function () {
        loadRecords();    
        $scope.ShowWeather = false;
    }


    //Method to Get weather information
    $scope.getWeatherInformation = function () {
        var promiseGetSingle = weatherService.getWeatherInformation($scope.CountryName, $scope.SelectedCity); //The method to call from service

        promiseGetSingle.then(function (pl) {
            $scope.WeatherInfo = pl.data; 
            var time = new Date();
            $scope.WeatherInfo.Time = time.getHours() + ":" + time.getMinutes() + ":" + time.getSeconds();
            $scope.ShowWeather = true;
            
        },
            function (errorPl) {
                console.log('failure loading Weather', errorPl);
            });
    } 

    
});