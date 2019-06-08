
$(() => {
    let turno = 1;
    $('.square').click((event)=>{
        if(turno%2 && !$(event.target).html()){
            $(event.target).append('<p class="jugado">X</p>');
            $('#turnoJugador').remove();
            $('#titulo').after('<p id="turnoJugador">Es el turno del Jugador '+ 2 + '</p>');
            turno++;
        }else if(!$(event.target).html()){
            $(event.target).append('<p class="jugado">0</p>');
            $('#turnoJugador').remove();
            $('#titulo').after('<p id="turnoJugador">Es el turno del Jugador '+ 1 + '</p>');
            turno++;
        }
        if(hasWin()){
            if(turno%2){
                setTimeout(alert("Gano el jugador 2"), 1000);
                location.reload();
            }else{
                setTimeout(alert("Gano el jugador 1"), 1000);
                location.reload();
            }
        }else if($('.jugado').length == 9){
            setTimeout(alert("¡No ha ganado ninguno! Vuelvan a jugar"), 1000);
            location.reload();
        }
    });
    var hasWin = () => {
        if($('#one').html()==$('#two').html() && $('#two').html() == $('#three').html() && $('#one').html()){
            return true;
        }else if($('#one').html()==$('#four').html() && $('#four').html() == $('#seven').html() && $('#one').html()){
            return true;
        }else if($('#one').html()==$('#five').html() && $('#five').html() == $('#nine').html() && $('#one').html()){
            return true;
        }else if($('#three').html()==$('#six').html() && $('#six').html() == $('#nine').html() && $('#three').html()){
            return true;
        }else if($('#three').html()==$('#five').html() && $('#five').html() == $('#seven').html() && $('#three').html()){
            return true;
        }else if($('#four').html()==$('#five').html() && $('#five').html() == $('#six').html() && $('#four').html()){
            return true;
        }else if($('#seven').html()==$('#eight').html() && $('#eight').html() == $('#nine').html() && $('#seven').html()){
            return true;
        }else if($('#two').html()==$('#five').html() && $('#five').html() == $('#eight').html() && $('#two').html()){
            return true;
        }
        return false;
    }

    // var isEmpty = () => {
    //     return $('.jugado').forEach((p) => {
    //         return p.html() == 0;
    //     });
    // }
});

