$(document).ready(function () {
    var carusers = {};
    var speedfactor;
    var carspeed = [];
    var chartypebuffer=0;
    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
    let connectionid = "";
    connection.start().then(function () {
        console.log("connected");

        connection.invoke('getConnectionId')
            .then(function (connectionId) {
                connectionid = connectionId;
                let data = {};
                data.gamename = gamename;
                data.connectionId = connectionid;
                data.playername = playername;
                connection.invoke("Joingame", data).catch(function (err) {
                    return console.log(err.toString());
                });
            }).catch(err => console.log(err.toString()));

    });

    let numClicks = 0;
    let secondsSpent = 0;
    //let c = 0;
    let givenTime = 90000;
    var secondsIntervalID;


    var curtext = "";

    $.getJSON(textfile, function (json) {
        console.log(json);
        $('#wholeText').html(json[trackid]);
        curtext = json[trackid];
    });
    



    //function randomNumber(min, max) {
    //    return Math.floor(Math.random() * (max - min) + min);
    //} 

    

    function randSel() {
        return Math.floor(Math.random() * 5);
    }


    $('#inputText').bind("cut copy paste", function (e) {
        e.preventDefault();
    });


    connection.on("Getmessage", function (message) {
        $('#testdiv').html(message);
    });
    connection.on("Getspeed", function (car, velocity) {
       // let c = parseFloat($('#' + car + "_container").css('bottom')) + velocity * speedScale;
        // console.log("velocity obtained: " + velocity);
        carspeed[car] = carspeed[car] + speedfactor;
        $('#' + car + "_container").css('bottom', carspeed[car] + 'px');
    });
    
    connection.on("Saywinner", function (winner, cpm) {
        let j = cpm.toFixed(0);
        $("#inputText").after("<div class='text-center' id='anwinner'><strong style = 'text-transform: capitalize;'>"+winner+"</strong> finished the game. (cpm: "+j+")</div>");
        
    });
    connection.on("StartCountDown", function () {
        startCountdown();
    });

    connection.on("UserDisconnected", function (thisgrpuser) {

        console.log("user left");
        console.log(thisgrpuser);
        $("#" + thisgrpuser.playername + "_container").remove();


    });


    connection.on("ThrowError", function (msg) {

        console.log(msg);


    });




    connection.on("UserConnectedOnGroup", function (thisgrpuser) {
        carusers = thisgrpuser;
        let car = "";
        $.each(thisgrpuser, function (i, v) {
            i++;
            car += `<div class="car_container" id="` + v.playername + `_container">
                    <img src="/img/car`+ i + `-01.png" id="car1">
                    <div class="player_name">`+ v.playername + `</div></div>`;
            carspeed[v.playername] = 0;
        });

        $("#carlist").html(car); 

    });
    function starttimer() {
         secondsIntervalID = setInterval(function () {
           
             secondsSpent++;
             //console.log("timer : "+secondsSpent);
            
        }, 1000);
    }
    function stoptimer() {
        clearTimeout(secondsIntervalID);
    }
    

    function cpm() {
        console.log("character typed: " + numClicks);
        console.log("seconds spent : " + secondsSpent);

        c = (numClicks / secondsSpent)*60;
        return c;
    }
    
    let buffertext = '';

    function invokeMove() {
        let car = playername;
        let d = chartypebuffer;
        //console.log("move car:" + d);
        connection.invoke("MoveCar", car, d, gamename).catch(function (err) {
            return console.error(err.toString());
        });
    }
    function announceWinner() {
        stoptimer();
        let m = cpm();
            connection.invoke("AnnounceWinner", playername, gamename,m).catch(function (err) {
                return console.error(err.toString());
            });
        
    }

    $('#inputText').keyup(function (e) {
        let code = e.keyCode || e.which;
       // console.log(code);
        let thistext = $(this).val();
        let len = thistext.length;


        if (code !== 16 && code !== 8) {
            if (curtext[numClicks] !== thistext[numClicks]) {
                $(this).val(buffertext);
                $(this).removeClass('wrongtype');
                $(this).addClass('wrongtype');

            }
            if (curtext[numClicks] === thistext[numClicks]) {
                buffertext = thistext;

                let yy = curtext.replace(thistext, '<span style="color: white;background-color:black;">' + thistext + '</span>');
                $('#wholeText').html(yy);
                numClicks++;
                //chartypebuffer = chartypebuffer + speedfactor;
                $(this).removeClass('wrongtype');
                invokeMove();

            }
            if (curtext === thistext) {
                $("#inputText").prop('disabled', true);
                
                $("#track").css("opacity", "0.1");
                $(".finishline").css("opacity", "0.1");
                announceWinner();
                if ($("#anwinner").length === 0) {
                    $("#track").after("<div class='text-center' style='top:50%;left:40%;position:absolute;'><h1>You Win</h1></div>");
                }
             
                
            }


        }




    });

    $(document).on('click', '#sendReady', function () {
        console.log(carusers.length);
        if (carusers.length < 2) {
            alert("There should be atleast 2 players.");
            return false;
        } 
        connection.invoke("MakeReady", gamename).catch(function (err) {
            return console.error(err.toString());
        });

        //let usrName = $('#carname').val();
        //if (usrName === '') {
        //    $('#carname').addClass('error');
        //    return false;

        //} else {
        //    $('#carname').removeClass('error');
           
        //}
    });
    function startCountdown() {
        $("#sendReady").prop("disabled", true);
        var i = 4;
        var timer = setInterval(function () {
            --i;
            $("#sendReady").text(i);
            if (i === 0) {
                clearInterval(timer);
                $("#sendReady").text("Go");
                $('#typeSection').show();
                $("#inputText").focus();
                speedfactor = determineSpeedfactor();
                starttimer();
               // $("#inviteurl").hide();
            };
            
        }, 1000);
        
    }
    function determineSpeedfactor() {
        let textlen = curtext.length;
        let trackheight = $("#track").height()-136;
        let f = parseFloat(trackheight / textlen );
        console.log("speed factor : " + f);
        return f;

    }

})

