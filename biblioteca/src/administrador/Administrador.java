
package administrador;
import java.sql.*;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import modelos.Autor;
import modelos.Libro;
import modelos.TipoPrestamo;

public class Administrador {
    
    public String cadena = "jdbc:sqlserver://DESKTOP-0CJ18MR;databaseName=Biblioteca";
    public String user = "sa";
    public String pass ="1234";
    Connection con;
    ResultSet rs;
    
    public Autor VerificarAutor(int X)
    { 
        Autor A = null;
          try 
          {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            con = DriverManager.getConnection(cadena, user, pass);
            PreparedStatement pt = con.prepareStatement("SELECT * FROM AUTORES WHERE ID_AUTOR= ?");
            pt.setInt(1, X);
            rs =  pt.executeQuery();
            rs.next();
            int id = rs.getInt(1);
            String nombre =rs.getString(2);
            String Nacionalidad = rs.getString(3);
            A = new Autor(id, nombre, Nacionalidad);
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
        return A;
       
    }
    public void AgregarLibro(Libro L)
    {
        try 
        {
            con = DriverManager.getConnection(cadena, user, pass);
            PreparedStatement pt = con.prepareStatement("INSERT INTO LIBROS VALUES (?,?,?)"); 
            pt.setString(1,L.getNombre());
            pt.setInt(2,L.getTipoPrestamo().getIdTipo());
            pt.setInt(3,L.getAutor().getId());
            pt.executeUpdate();
            con.close();
        }
        catch (Exception e) 
        {
            e.printStackTrace();
        }
        
    }
    public ArrayList<TipoPrestamo> TipoPrestamos()
    { 
        ArrayList<TipoPrestamo> Lista = new ArrayList<>();
                  try 
          {
            con = DriverManager.getConnection(cadena, user, pass);
            PreparedStatement pt = con.prepareStatement("SELECT * FROM AUTORES WHERE ID_AUTOR= ?");
            pt.setInt(1, X);
            rs =  pt.executeQuery();
            rs.next();
            int id = rs.getInt(1);
            String nombre =rs.getString(2);
            String Nacionalidad = rs.getString(3);
            A = new Autor(id, nombre, Nacionalidad);
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
        return null;
    
    
    }
    
    
    
}
