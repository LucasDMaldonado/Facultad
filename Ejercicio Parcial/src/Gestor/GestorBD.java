
package Gestor;
import Models.DTOReporte1;
import Models.Oferta;
import Models.Producto;
import java.sql.*;
import java.util.ArrayList;

public class GestorBD {
    
    private String Cadena ="jdbc:sqlserver://DESKTOP-0CJ18MR;databaseName=EjercicioParcial";
    private String User = "sa";
    private String Pass = "1234";
    Connection con;
    PreparedStatement st;
    ResultSet rs;
    
    
   public void cargarOferta(Oferta O)
    {
        
        try 
        {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            con = DriverManager.getConnection(Cadena, User, Pass);
            st = con.prepareStatement("INSERT INTO Oferta VALUES (?,?,?,?,?,?)");
            st.setInt(1, O.getProd().getIdProducto());
            st.setDouble(2, O.getPrecionNormal());
            st.setDouble(3, O.getPrecioOferta());
            st.setInt(4, O.getStock());
            st.setString(5, O.getFechaInicio());
            st.setInt(6, O.getDiasVigencia());
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
    public ArrayList<Producto> ListaProducto()
    { 
        ArrayList<Producto> Lista = new ArrayList<>();
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                Statement pt = con.createStatement();
                rs =pt.executeQuery("SELECT * FROM Producto");          
                  while (rs.next()) 
                  {      
                    int id = rs.getInt(1);
                    String nombre =rs.getString(2);
                    Producto P = new Producto(id, nombre);
                    Lista.add(P);
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
    public DTOReporte1 ListaOferta(Producto p)
    { 
        DTOReporte1 Repo = null;
           try 
           {
                con = DriverManager.getConnection(Cadena, User, Pass);
                PreparedStatement pt = con.prepareStatement("select sum(precioNormal - precioOferta) * stockDisponible 'monto perdido',p.nombre\n" +
                                    "from Oferta o\n" +
                                    "join Producto p on o.idProducto = p.id\n" +
                                    "where p.id = ?\n" +
                                    "group by stockDisponible,p.nombre");
                pt.setInt(1, p.getIdProducto());
                rs =pt.executeQuery();          
                if ( rs.next()) {
                   double monto = rs.getDouble(1);
                    String nombre =rs.getString(2);
                    Repo = new DTOReporte1(monto, nombre);
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
    
    
}
