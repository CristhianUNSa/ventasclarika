function traerVentasCliente(clienteId) {
    if (clienteId > 0) {
        $.getJSON("api/ventas?ClienteID=" + clienteId)
            .done(function(data) {
                var html = $("#theTmpl").render([data]);
                $("#divVentas").html(html);
                var total = 0;
                for (var i = 0; i < data.length; i++) {
                    var monto = data[i]["Monto"];
                    if (monto > 0) {
                        total += monto;
                    }
                }
                $("#spnTotal").text("$" + total);
            });
    } else {
        $("#divVentas").empty();
    }
}