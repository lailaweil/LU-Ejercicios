
$(() => {
    var vuelta = 1;
    var correctas = 0;
    
    var preguntas = [
    {   pregunta:"¿Dónde surgió la filosofía?",
        opciones: ['Grecia', 'España', 'Egipto', 'Japón'],
        respuesta: 'Grecia'
    },
    {   pregunta:"¿Cuántos versos tiene un soneto?",
        opciones: ['14', '16', '8', '20'],
        respuesta: '14'
    },{
        pregunta:"¿Qué odia Mafalda?",
        opciones: ['La sopa', 'El pájaro Loco', 'Los panqueques', 'A Manolito'],
        respuesta: 'La sopa'
    },{
        pregunta:"¿Quién compuso la famosa canción Bohemian Rhapsody?",
        opciones: ['Freddy Mercury', 'Elton John', 'David Bowie', 'John Lennon'],
        respuesta: 'Freddy Mercury'
    },{
        pregunta:"¿Cuántos cuadros tiene un tablero de ajedres?",
        opciones: ['64', '128', '76', '32'],
        respuesta: '64'
    },{
        pregunta:"¿Cuántos soldados argentinos murieron en la Guerra de las Malvinas?",
        opciones: ['649', '200', '987', '1452'],
        respuesta: '649'
    },{
        pregunta:"¿Quién es la mascota de SEGA?",
        opciones: ['Sonic', 'Mario', 'Ryu', 'Pac Man'],
        respuesta: 'Sonic'
    },{
        pregunta:"¿Qué personaje de Disney perdió su zapato de cristal?",
        opciones: ['Cenicienta', 'Tiana', 'Blancanieves', 'La Sirenita'],
        respuesta: 'Cenicienta'
    },{
        pregunta:"¿Qué estudia la icitología?",
        opciones: ['Los peces', 'Las rocas', 'Las erupciones cutáneas', 'Los insectos'],
        respuesta: 'Los peces'
    },{
        pregunta:"¿Cuántos países hay en el mundo?",
        opciones: ['196', '192', '189', '214'],
        respuesta: '196'
    }];

    $(document).keydown((event) =>{
        
        if(vuelta==1){
            $('#one').removeAttr('id');
            $('.box').remove();
            $('#container').append('<div id="vuelta" class="box"><h2>Pregunta ' + vuelta + '</h2></div>');
            $('#vuelta').append('<p id="pregunta">'+ preguntas[vuelta-1].pregunta+'</p>');
            $('#vuelta').append('<div id="opciones"></div>');
            
            shuffle(preguntas[vuelta-1].opciones).forEach(opcion => {
                $('#opciones').append('<button class="btn btn-outline-primary">' + opcion + '</button>');
            });
            $('#score').remove();
            $('footer').append('<p id="score">Pregunta '+ vuelta +'/10</p>');
            vuelta ++;
            pressed();
        }
    });

    var pressed = ()=> {$('.btn-outline-primary').click(function(event) {
            
            if(vuelta != 11){
                if(esCorrecta($(this).text())){
                    $(this).attr('class', 'btn btn-success');
                    correctas++;                    
                }else{
                    $(this).attr('class', 'btn btn-danger');
                   
                }
                setTimeout(function(){
                    $('.box').remove();
                    $('#container').append('<div id="vuelta" class="box"><h2>Pregunta ' + vuelta + '</h2></div>');
                    $('#vuelta').append('<p id="pregunta">'+ preguntas[vuelta-1].pregunta+'</p>');
                    $('#vuelta').append('<div id="opciones"></div>');
                        
                    shuffle(preguntas[vuelta-1].opciones).forEach(opcion => {
                        $('#opciones').append('<button class="btn btn-outline-primary">' + opcion + '</button>');       
                    });
                    $('#score').remove();
                    $('footer').append('<p id="score">Pregunta '+ vuelta +'/10</p>');
                    vuelta ++;
                    pressed();
                }, 500);
                

            }else{
                setTimeout(function(){
                    if(esCorrecta($(event.target).text())){
                        console.log('entre');
                        $(event.target).removeClass('btn btn-outline-primary');
                        $(event.target).addClass('btn btn-success');
                        correctas++; 
                    }else{
                        console.log('entre mal');
                        $(event.target).attr('class', 'btn btn-danger');
                    }
                    $('.box').remove();
                    $('#container').append('<div id="resultados" class="box"><h2>Respuestas Correctas: '+ correctas +'/10</h2></div>');
                }, 500);
            }
       });
    }
    
    function shuffle(opciones) {
        for (let i = opciones.length - 1; i > 0; i--) {
            const j = Math.floor(Math.random() * (i + 1));
            [opciones[i], opciones[j]] = [opciones[j], opciones[i]];
        }
        return opciones;
    }

    var esCorrecta = (rta) =>{
        return rta == preguntas[vuelta-2].respuesta;
    }
});

