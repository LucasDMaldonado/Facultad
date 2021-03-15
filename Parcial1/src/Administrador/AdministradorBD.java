
package Administrador;

import DTO.DtoListaMascotas;
import DTO.DtoListaPerros;
import DTO.DtoReporte1;
import Models.Cliente;
import Models.Especie;
import Models.Mascota;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;


public class AdministradorBD {
    private String Cadena ="jdbc:sqlserver://DESKTOP-0CJ18MR;databaseName=Veterinaria";
    private String User = "sa";
    private String Pass = "1234";
    Connection con;
    PreparedStatement st;
    ResultSet rs;
     public void cargarMascota(Mascota M)
    {
        
        try 
        {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            con = DriverManager.getConnection(Cadena, User, Pass);
            st = con.prepareStatement("INSERT INTO Mascotas VALUES (?,?,?,?)");
            st.setString(1, M.getNombre());
            st.setInt(2, M.getCliente().getIdCliente());
            st.setInt(3, M.getEspecie().getIdEspecie());
            st.setInt(4, M.getNacimiento());
            st.executeUpdate();
                    
        } catch (Exception e) 
        {
            e.printStackTrace();
        }
        finally
        {
            try {
                con.close();
            } catch (Exception e) 
            {
                e.printStackTrace();
            }
        }
    }
    public ArrayList<DtoListaMascotas> ListaMascotas()
    { 
        ArrayList<DtoListaMascotas> Lista = new ArrayList<>();
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                Statement pt = con.createStatement();
                rs =pt.executeQuery("SELECT M.Nombre,C.Nombre,C.Telefono\n" +
                                    "FROM Mascotas M\n" +
                                    "JOIN Clientes C ON M.IdCliente =C.IdCliente\n" +
                                    "ORDER BY C.Nombre DESC");          
                  while (rs.next()) 
                  {      
                    String Mascota = rs.getString(1);
                    String Cliente =rs.getString(2);
                    String Telefono = rs.getString(3);
                    DtoListaMascotas DT = new DtoListaMascotas(Mascota, Cliente, Telefono);
                    Lista.add(DT);
                  }
                rs.close();          
            } 
          catch (Exception e) 
          {
              e.printStackTrace();
          }
          finally
          {
              try 
              {
                  con.close();
              } 
              catch (Exception e) 
              {
                  e.printStackTrace();
              }
               
          }
        return Lista;
    
    
    }
public double promedioEdad()
    { 
        double Repo = 0;
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                Statement pt = con.createStatement();
                rs =pt.executeQuery("SELECT AVG(2020-Nacimiento) 'Promedio'\n" +
                                                            "  FROM Mascotas");
                rs =st.executeQuery();          
                if ( rs.next()) {
                   double prom = rs.getDouble(1);
                    Repo = prom;
               }

                rs.close();          
            } 
          catch (Exception e) 
          {
              e.printStackTrace();
          }
          finally
          {
              try 
              {
                  con.close();
              } 
              catch (Exception e) 
              {
                  e.printStackTrace();
              }
               
          }
        return Repo;
    
    
    }
     public ArrayList<Cliente> ListaCliente()
    { 
        ArrayList<Cliente> Lista = new ArrayList<>();
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                Statement pt = con.createStatement();
                rs =pt.executeQuery("Select * From Clientes");          
                  while (rs.next()) 
                  {      
                    int Id = rs.getInt(1);
                    String Cliente =rs.getString(2);
                    String Telefono = rs.getString(3);
                    Cliente C = new Cliente(Id, Cliente, Telefono);
                    Lista.add(C);
                  }
                rs.close();          
            } 
          catch (Exception e) 
          {
              e.printStackTrace();
          }
          finally
          {
              try 
              {
                  con.close();
              } 
              catch (Exception e) 
              {
                  e.printStackTrace();
              }
               
          }
        return Lista;
    
    
    }
         public ArrayList<Especie> ListaEspecies()
    { 
        ArrayList<Especie> Lista = new ArrayList<>();
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                Statement pt = con.createStatement();
                rs =pt.executeQuery("Select * From Especies");          
                  while (rs.next()) 
                  {      
                    int Id = rs.getInt(1);
                    String Descripcion =rs.getString(2);
                    Especie C = new Especie (Id,Descripcion);
                    Lista.add(C);
                  }
                rs.close();          
            } 
          catch (Exception e) 
          {
              e.printStackTrace();
          }
          finally
          {
              try 
              {
                  con.close();
              } 
              catch (Exception e) 
              {
                  e.printStackTrace();
              }
               
          }
        return Lista;
    
    
    }

    public ArrayList<DtoListaPerros> ListaMascotasPerro()
    { 
        ArrayList<DtoListaPerros> Lista = new ArrayList<>();
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                Statement pt = con.createStatement();
                rs =pt.executeQuery("SELECT m.Nombre as 'Mascota', c.Nombre, m.Nacimiento\n" +
                                    "  FROM Mascotas m\n" +
                                    "  JOIN Clientes c\n" +
                                    "    ON m.IdCliente=c.IdCliente\n" +
                                    "  JOIN Especies e\n" +
                                    "    ON e.IdEspecie=m.IdEspecie\n" +
                                    " WHERE Denominacion = 'Perro%'");          
                                                      while (rs.next()) 
                  {      
                    String Mascota = rs.getString(1);
                    String Cliente =rs.getString(2);
                    String Descripcion = rs.getString(3);
                    DtoListaPerros DT = new DtoListaPerros(Mascota, Cliente, Descripcion);
                    Lista.add(DT);
                  }
                rs.close();          
            } 
          catch (Exception e) 
          {
              e.printStackTrace();
          }
          finally
          {
              try 
              {
                  con.close();
              } 
              catch (Exception e) 
              {
                  e.printStackTrace();
              }
               
          }
        return Lista;
    
    
    }
}
