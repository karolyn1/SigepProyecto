$(document).ready(function () {
    function capitalizeWords(str) {
        return str
            ? str.toLowerCase().split(' ').map(word =>
                word.charAt(0).toUpperCase() + word.slice(1)
            ).join(' ')
            : "";
    }

    function ConsultarPersonaApi() {
        $("#nombre").val("");
        $("#apellido1").val("");
        $("#apellido2").val("");

        let identificacion = $("#cedula").val();

        if (identificacion.length >= 9) {
            $.ajax({
                type: 'GET',
                url: 'https://apis.gometa.org/cedulas/' + identificacion,
                dataType: 'json',
                success: function (data) {
                    if (data.resultcount > 0) {
                        let persona = data.results[0];
                        $("#nombre").val(capitalizeWords(persona.firstname1));
                        $("#apellido1").val(capitalizeWords(persona.lastname1));
                        $("#apellido2").val(capitalizeWords(persona.lastname2));
                    } else {
                        alert("No se encontró información para esa cédula");
                    }
                },
                error: function () {
                    alert("Error al consultar la API");
                }
            });
        }
    }
    $("#cedula").on("keyup", ConsultarPersonaApi);

});