<%-- 
    Document   : listadoVentas
    Created on : 09/10/2020, 22:02:44
    Author     : nbcschneidt2
--%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        
    </head>
    <body>
        
            
        <c:choose>
            <c:when test="${ not empty usr}">
                <form action="Ventas">
                    <input name="modo" type="hidden" value="alta" />
                    <input type="submit" value="Alta de Venta" />
                </form>
                <button onclick="window.location = 'Ventas?modo=alta';">Nueva Venta</button>
                <a href="Ventas?modo=alta">Alta de Venta</a>
                <table>
                    <tr><th>Producto</th><th>Cantidad</th><th>Importe</th><th></th></tr>
                    <c:forEach items="${ ventas }" var="item">
                        <tr><td>${ item.producto }</td><td> ${ item.cantidad }</td><td> ${ item.importe }</td>
                            <td><a href="Ventas?modo=editar&id=${ item.id }">Editar</a></td>
                        </tr>
                    </c:forEach>
                </table>
            </c:when>
            <c:otherwise>
                <%@include file="infoError.jsp" %>
            </c:otherwise>
        </c:choose>
    </body>
</html>
