using MySql.Data.MySqlClient;


namespace Practica6	
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}

		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=profesores;" +
	          	"User ID=root;" +
	          	"Password=naruto11;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}

		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}