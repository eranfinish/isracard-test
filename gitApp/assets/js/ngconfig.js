
//angular.module("gitApp", []).factory('tradeFactory', function ($q) {
//    var _ready = $q.defer();
//    return {
//        ready: function () {
//            return _ready.promise;
//        },
//        ResolveReady: function () {
//            _ready.resolve(1);
//        }
//    }
//});

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
                        var data = item;
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
      
            })
    //.state('event', {
    //    name: 'event',
    //    controller: 'RegisterController',
    //    url: '/event/:formid/:typeid/:indexapp/:cycleid',
    //    params: {
    //        formid: { squash: true, value: null },
    //        typeid: { squash: true, value: null },
    //        indexapp: { squash: true, value: null },
    //        cycleid: { squash: true, value: null }
    //    },
    //    templateUrl: 'Scripts/AngularJS/New/htmlTemplate/register.html?v=1.5',
    //    resolve: {
    //        cyclesResolved: function (myService, userService, $stateParams) {

    //            var formid = $stateParams.formid;
    //            var cycleid = $stateParams.cycleid != undefined ? $stateParams.cycleid : '';
    //            var typeid = $stateParams.typeid;
    //            var indexapp = $stateParams.indexapp != undefined ? $stateParams.indexapp : '';
    //            console.log("In Event Resolve");

    //            return myService.getFormCycles(formid, typeid, cycleid, indexapp);
    //            //    .then(function (result) {
    //            //       return result.data;
    //            //});

    //            //         return myService.getFormCycles(formid, typeid, cycleid, indexapp);
    //        }  //},
    //        //testData: function (Test) {

    //        //    var datatest = Test.query();

    //        //    return datatest.$promise;
    //        //}ui

    //    }
    //})

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


