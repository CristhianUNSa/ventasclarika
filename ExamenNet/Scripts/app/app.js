function traerVentasCliente(clienteId) {
    $.get("api/ventas", { ClienteID: clienteId }, function (data) {
        $("#divVentas").html(data);
    });
}