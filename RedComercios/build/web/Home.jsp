<%-- 
    Document   : Home
    Created on : 30 oct. 2020, 20:04:58
    Author     : panic
--%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
             <title>JSP Page</title>
             <%@include file="WEB-INF/bootstrap.jsp" %>
    </head>
    
    <body>
  
  <%@include file="WEB-INF/navbar.jsp" %>
  <br>
  <br>
  <br>
  
    

  <div class="container">

    <h1 class="my-4">Bienvenido a nuestro market de Ofertas</h1>

    <h2>Rubros</h2>

    <div class="row">
     <c:forEach items="${Rubros}" var="item">
      <div class="col-lg-4 col-sm-6 portfolio-item">
        <div class="card h-100">
          <a href="ComercioServ?id=${item.idRubro}&rubro=${item.descripcion}"><img class="card-img-top" src="ImagenesSubidas/${item.img}.jpg" alt=""></a>
          <div class="card-body">
            <h4 class="card-title">
              <a href="ComercioServ?id=${item.idRubro}&rubro=${item.descripcion}">${ item.descripcion }</a>
            </h4>
          </div>
        </div>
      </div>
      </c:forEach>  
    </div>


    <hr>


    <div class="row mb-4">
      <div class="col-md-8">
      </div>
      <div class="col-md-4">
          <a class="btn btn-lg btn-secondary btn-block" href="Login">Administrar</a>
      </div>
    </div>

  </div>

  <%@include file="WEB-INF/Footer.jsp" %>
    
     </body>
</html>
