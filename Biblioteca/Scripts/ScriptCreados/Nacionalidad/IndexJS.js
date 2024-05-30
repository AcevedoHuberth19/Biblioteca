$(document).ready(function () {

    const GridPrincipal = $("#ContParcial").html();

    let table = new DataTable('#Lista', {
        responsive: true,
        "pageLength": 4,
        "bLengthChange": false,
        language: {
            url: '//cdn.datatables.net/plug-ins/2.0.3/i18n/es-ES.json',
        }
    });

    $("#Guardar").on("click", function () {
        
        EjecutarPost();
    });

    function EjecutarPost()
    {        
        const $form = $("#FormNacionalidad");
        const Ruta = $form.attr("action");
        var abreviatura = "";

        $.ajax({
                url: Ruta,
                type: "POST",
                data: $form.serialize(),
                success: function (data)
                {
                    if (vista != "") {
                        $("#ContParcial").html(data.vista);
                    } else
                    {
                        $("#ContParcial").html(GridPrincipal); 
                    }
                        
                                        
                }

            });
    }
    
    

})