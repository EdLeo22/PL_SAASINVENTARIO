var g_Dominio = "localhost";
var TLC = 60

//Función para iniciar sesión
function
var obj_Parametros_JS = new Array();

//Capturar los valores del formulario
obj_Parametros_JS[0] = $("#txtCorreo").val();
obj_Parametros_JS[1] = $("#txtPassword").val();

//Crear la estructura de parámetros  en formato Json
var parametros = Json.stringify({ 'ob_Parametros_JS ': obj_Parametros_JS })

jQuery.ajax({
    type: "POST",
    url: "frmInicioSesion.aspx/InicioSesionUsuarios",
    data: parametros,
    contentType: "application/json; charset=utf-8",
    dataType: "json",
    cache: false,
    success: function (msg) {
        var res = msg

        if (res.d == undefined) {
            swal.fire({
                position: 'center-center',
                icon: 'error',
                title: 'Error en la conexión',
                Text: 'Error en la conexión a la base de datos',
            })
        }
        else
            var arreglo = new Array();
        var str;
        str = res;

        arreglo = (str.split("<SPLITER>"));

        var resultado = arreglo[0];

        if (resultado != "0") && (resultado != "-1") {
            $.cookie('USRUNI', arreglo[0], { expires: TLC, path: '/', domain: g_Dominio });
            $.cookie('USREML', arreglo[1], { expires: TLC, path: '/', domain: g_Dominio });
            $.cookie('USRNOM', arreglo[2], { expires: TLC, path: '/', domain: g_Dominio });

            swal.fire({
                position: 'center-center',
                icon: 'success',
                title: 'Inicio de sesión de usuarios',
                Text: arreglo[1],
                showConfirmButton: false,
                timer: 4500,
                timerprogressBar: true,
            });

            SetTimeout(function () {
                location.href = "../Inventrix/frmInventrix.aspx";
            }4500);
        }
        else {
        swal.fire({
            position: 'center-center',
            icon: 'error',
            title: 'Inicio de sesion de usuarios',
            Text: arreglo[1],
            showConfirmButton: false,
            timer: 4500,
            timerprogressBar: true,
        })
    }
}
})
