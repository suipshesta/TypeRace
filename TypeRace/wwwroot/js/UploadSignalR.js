(function () {
    var connection = new signalR.HubConnectionBuilder().withUrl("/connectionHub").build();

    connection.start().then(function () {

        connection.invoke('getConnectionId')
            .then(function (connectionId) {
                curClientId = connectionId;
                console.log("connected: " + connectionId);
                sessionStorage.setItem('conectionId', connectionId);
                // Send the connectionId to controller
            }).catch(err => console.error(err.toString()));;


    });

    $("#sendmessage").click(function () {
        var connectionId = sessionStorage.getItem('conectionId');
        connection.invoke("Send", connectionId);
    });

    connection.on("ReceiveCompleteMessage", function (fileId) {
        console.log(fileId);
        $("#" + fileId).html("Done");
    });

})();