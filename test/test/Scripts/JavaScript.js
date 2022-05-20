const api = "api/Cars";

$(document).ready(function () {
    $.get(api, function (response) {
        if (response.data !== undefined) {
            var cars = JSON.parse(response.data);

            if (cars.length > 0) {
                var res = "<table><tr><th>Name</th><th>Model</th><th>Volume</th>";
                for (let i = 0; i < car.length; i++) {
                    res += "<tr><td>" + car[i].Name + "</td>" +
                        "<td>" + car[i].Model + "</td>" +
                        "<td>" + car[i].Volume + "</td>" +
                        "</tr>"
                }
                res += "</table>";
                $(document).append(res);
            }

        }
    });

    $.delete(api, function (response) {
        if (response.data !== undefined) {
            //  ....
        });
})