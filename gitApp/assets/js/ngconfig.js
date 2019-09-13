


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
    $urlRouterProvider.otherwise("/home");
    $stateProvider.state('home', {
        
        controller: function ($scope, $http) {
            $scope.getRepos = function () {
                if ($scope.search.length > 2) {



                    $http.get("https://api.github.com/search/repositories?q=" + $scope.search)
                        .then(function (response) {
                            console.log(response.data);
                            $scope.repos = response.data.items;
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
                    // $scope.bmImage = "fullBM.png";
                    checkItem(item);
                }
                else {
                   res =  bm.replace("fullBM.png","emptyBM.png" );
                }
                document.getElementById("bm_" + id).src = res;
            }
                var checkItem = function (item) {
                    //  item["check"] = item["check"] ? false : true;
                    console.log(item.check);
                   
                        var config = {
                            headers: {
                                "Content-Type": "application/json; charset=utf-8"
                            }
                    };
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
        controller: function ($scope, $http) {
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


