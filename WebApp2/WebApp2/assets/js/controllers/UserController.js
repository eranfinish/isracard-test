app.controller("UserController", function ($scope, $http) {
    $scope.hello = "Shalom";
    $scope.res = '';
    $http.get("http://localhost:51475/api/values").then(
        function (response) {
            console.log(response.data);
        });
    var data = [{ 'name': 'Rum 1', 'id': 'a31d1fc8-df29-419c-8308-f8bc884b378e', 'seats': 10, 'availableFrom': null, 'availableTo': null },
    { 'name': 'Rum 2', 'id': '7defd34d-222d-4980-b28f-e616e8b9003c', 'seats': 5, 'availableFrom': null, 'availableTo': null },
    { 'name': 'Skrubben', 'id': 'b20390ff-703b-4d80-8c2f-32c0f27158bc', 'seats': 5, 'availableFrom': 10, 'availableTo': 11 },
    { 'name': 'Hangaren', 'id': 'b89cbacd-c738-477f-aff2-7f22c2b2cd5c', 'seats': 100, 'availableFrom': null, 'availableTo': null },
    { 'name': 'Tv-rummet', 'id': 'ea6a290f-209b-4ccb-91a4-65d82a674bad', 'seats': 10, 'availableFrom': null, 'availableTo': null },
    { 'name': 'Projektor-rummet', 'id': '3136a56a-4a28-4939-aca8-806534c808f7', 'seats': 12, 'availableFrom': null, 'availableTo': null },
    { 'name': 'Skolsalen', 'id': '05f73582-3734-453f-aeb3-36daf8884912', 'seats': 30, 'availableFrom': null, 'availableTo': null }];
    // var names = [];
    $scope.list = "";
    for (let i = 0; i < data.length; i++) {
        //  if (data[i].name.indexOf(str, 0) > -1) {
        $scope.list += data[i].name + ",";
        // }

    }

    $scope.getResult = function (item) {
        $scope.res = item;
    }
}



).filter("startsWith", function () {
    var starts = function (input, option) {
        var output = [];
        for (var i = 0; i < input.length; i++) {
            if (input[i].toLowerCase().indexOf(option) === 0) {
                output.push(input[i]);
            }
        }
        return output;
    }
    return starts;
}).component("ngAutocomlete", function () {
    
})