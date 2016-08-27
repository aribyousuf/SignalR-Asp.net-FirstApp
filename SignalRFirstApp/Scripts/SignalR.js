$.connection.hub.start()
    .done(function () {
        console.log("It worked")
        $.connection.myHub.server.work("Connected !");
    })
    .fail(function () {
        alert("Error")
    });
$.connection.myHub.client.work = function (message) {
    $("#main").append(message + "<br />")
}