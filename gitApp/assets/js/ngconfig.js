/*This File is to config a route to to the views */
app.service("myService", [function () {
    var data = {};
    // TODO: optionally via HTML5 getter/setter way
    return {
        get: function (key) { return data[key]; },
        set: function (key, newData) { data[key] = newData; }
    };
}]);
app.config(function ($stateProvider, $urlRouterProvider, $locationProvider, $compileProvider, $urlMatcherFactoryProvider) {
    //$locationProvider.html5Mode({
    //    enabled: true
    //});
    //  $locationProvider;
    //$compileProvider.debugInfoEnabled(false);
    //$compileProvider.commentDirectivesEnabled(false);
    // $compileProvider.cssClassDirectivesEnabled(false);

    $urlMatcherFactoryProvider.strictMode(false);
    $urlMatcherFactoryProvider.caseInsensitive(true);
  //  $locationProvider.hashPrefix('');
    $urlRouterProvider.otherwise("/home");//Default view


    $stateProvider.state('home', {// View for the search 
        
        controller: function ($scope, $http, myService) {
            $scope.search = myService.get("search") !== undefined ? myService.get("search") : "";

            $scope.getRepos = function () {
                if ($scope.search.length > 2) { //AJAX to server after 3 characters of input



                    $http.get("https://api.github.com/search/repositories?q=" + $scope.search)
                        .then(function (response) {
                            myService.set("search", $scope.search);
                            console.log(response.data);
                            $scope.repos = response.data.items;
                            myService.set("repos", $scope.repos);
                            //console.log($scope.repos);
                        });
                }
            }
            $scope.bmImage = "emptyBM.png";
            $scope.bookmark = function (item) {
                let id = item.id;
                let bm = document.getElementById("bm_" + id).src;
                let res = "";
                if (bm.indexOf("emptyBM.png") > -1) {
                    res = bm.replace("emptyBM.png","fullBM.png");
                }
                else {
                   res =  bm.replace("fullBM.png","emptyBM.png" );
                }
                checkItem(item);
                document.getElementById("bm_" + id).src = res;
            }
                var checkItem = function (item) {
                 
                    console.log(item.check);
                   
                    //    var config = {
                    //        headers: {
                    //            "Content-Type": "application/json; charset=utf-8"
                    //        }
                    //};
                    var data = JSON.stringify(item);
                        //$http.post("Default.aspx/BookmarkRepo", JSON.stringify(data), config).then(function (response) {

                        //}
                        //);
                        $http({
                            url: "Default.aspx/BookmarkRepo",
                            method: "POST",
                            data: { "obj": data },
                            headers: { 'Content-Type': "application/json; charset=utf-8" }
                        }).then(function (response) {

                        }
                        );
                    
                }
            },
        url: '/home',
        templateUrl: 'assets/htmlTemplates/main.html',
      
    }).state('bookmarked', {
        controller: function ($scope, $http, myService) {
            $scope.bookmarks = {};
            $http({
                url: "Default.aspx/BookmarkRepo",
                method: "POST",
                data: { "obj": "Here" },
                headers: { 'Content-Type': "application/json; charset=utf-8" }
            }).then(function (response) {
                if (response.data.d !== undefined) {
                    $scope.bookmarks = JSON.parse(response.data.d);
                    console.log(JSON.parse(response.data.d));
                }

            
            }
            );
        },
        url: '/bookmarked',
        templateUrl:'assets/htmlTemplates/bookmarked.html'
    })


})




.run([
    '$rootScope', '$state', '$stateParams',
    function ($rootScope, $state, $stateParams) {
        // Attach state variables to rootScope so we can access them
        // in controllers.
        //loading controls

        console.log("From Run:");
        // $rootScope.ajaxWait  = true;
        console.log($stateParams.activity);
        $rootScope.$state = $state;
        $rootScope.$stateParams = $stateParams;

        $rootScope.$on('$stateChangeError', function (event, toState, toParams, fromState, fromParams, error) {
            throw error;
            //document.body.style.cursor = 'default';
        });
    }
]);


//app.factory('Test', ['$resource', function ($resource) {  


//    return $resource('http://localhost/amitservices/api/Cycles/Form/934/3/1');
//}]);


