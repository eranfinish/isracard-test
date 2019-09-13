var app = angular.module("gitApp", ['ui.router']);
    app.controller("mainCtrl", function ($scope, $http) {
    $http.get("https://api.github.com/search/repositories?q=YOUR_SEARCH_KEYWORD")
        .then(function (response) {
            console.log(response.data);
            $scope.repos = response.data.items;
           
        });

    $scope.checkItem = function (item) {
     
        console.log(item.check);
        if (item.check) {
            var config = {
                headers: {
                    "Content-Type": "application/json; charset=utf-8"
                }
            };
            var data = item;
            $http({
                url: "Default.aspx/BookmarkRepo",
                method: "POST",
                data: { "obj": data },
                headers: { 'Content-Type': "application/json; charset=utf-8" }
            }).then(function (response) {
                
            }
            );
        }
    }


}

)