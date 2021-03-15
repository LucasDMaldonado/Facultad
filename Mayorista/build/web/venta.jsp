<%-- 
    Document   : venta
    Created on : 09/10/2020, 21:40:05
    Author     : nbcschneidt2
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Registrar Ventas</title>
    </head>
    <body>
        <c:choose>
            <c:when test="${ not empty usr}">
                <h1>Alta de Venta</h1>
                <form action="Ventas" method="post">
                    <p>
                        <label>Producto: </label>
                        <select name="cmbProducto">
                            <c:forEach items="${ listadoProductos }" var="item">
                                <option value="${ item.id }">${ item.descripcion }</option>
                            </c:forEach>
                        </select>
                    </p>
                    <p>
                        <label>Cantidad: </label>
                        <input name="txtCantidad" />
                    </p>
                    <input type="submit" value="Aceptar" />
                </form>
            </c:when>
            <c:otherwise>
                <%@include file="infoError.jsp" %>
            </c:otherwise>
        </c:choose>
    </body>
</html>
