<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PL_SAASINVENTARIO._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<h2>Registro de productos:</h2>

<div class="container">

    <!-- FILTROS -->
    <div style="margin-bottom:15px;">
        <input type="text" id="txtBuscar" placeholder="Buscar producto" />
        <input type="number" id="txtEstado" placeholder="Estado (1,2...)" />
        <button onclick="listar()">Buscar</button>
    </div>

    <!-- TARJETAS -->
    <div class="cards">
        <div class="card blue">
            <p>Total de Productos</p>
            <h2 id="totalProductos">0</h2>
        </div>

        <div class="card green">
            <p>Valor Total del Inventario</p>
            <h2 id="valorInventario">₡0</h2>
        </div>

        <div class="card red">
            <p>Stock Bajo</p>
            <h2 id="stockBajo">0</h2>
        </div>
    </div>

    <!-- BOTÓN -->
    <div class="acciones">
        <button onclick="abrirModal()">+ Añadir Nuevo Producto</button>
    </div>

    <!-- TABLA -->
    <table id="tablaProductos" class="tabla"></table>

</div>

<script>
    function listar() {

        let parametros = [];
        parametros.push(1);
        parametros.push(document.getElementById("txtBuscar").value);
        parametros.push(document.getElementById("txtEstado").value || 0);

        fetch("Default.aspx/CargarProductos", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ obj_Parametros_JS: parametros })
        })
            .then(res => res.json())
            .then(data => {
                document.getElementById("tablaProductos").innerHTML = data.d;
            });
    }

    window.onload = listar;
</script>

</asp:Content>