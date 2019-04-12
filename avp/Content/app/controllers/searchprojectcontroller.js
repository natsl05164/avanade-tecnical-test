avpApp.controller("SearchProjectController", SearchProjectController);

function SearchProjectController($scope, $window, $compile, $filter,$http) {
    var vm = this;
    getAllProject();  
    vm.init = function () {

       getAllProject();
    }

    function getAllProject() {

        var data = ajaxGetAllProject();

        data.then(function (r) {
            console.log(r.data);
            vm.lstProject = r.data;
        }, function (r) {
            console.log(r.data);
        })
        
        
    }
 
    function ajaxGetAllProject() {
        return $http.get("/api/projectapi/GetAllProjects/" );
    }
 
}

