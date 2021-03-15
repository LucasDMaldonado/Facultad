<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
    </head>
    <body>
        <h1>Iniciar Sesión</h1>
        <% if(request.getAttribute("mensajeError") != null && !request.getAttribute("mensajeError").equals("")) { %>
            <h2>${ mensajeError }</h2>
        <% } %>
        <form method="post" action="Login">
            <p>
                <label>Usuario: </label>
                <input name="txtUsuario" />
            </p>
            <p>
                <label>Contraseña: </label>
                <input type="password" name="txtPass" />
            </p>
            <input type="submit" value="Iniciar Sesión" >
        </form>
    </body>
</html>
