using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca_BBDD
{
    public class ConexionBBDD
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static ConexionBBDD()
        {
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB ; initial Catalog=parcial_2; Integrated Security = true";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

        }

        public static void EliminarALumno(int legajo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE from ALUMNOS WHERE LEGAJO = @legajo";
                command.Parameters.AddWithValue(@"legajo", legajo);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void EliminarAdmin(int legajo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE from ADMINISTRADORES WHERE LEGAJO = @legajo";
                command.Parameters.AddWithValue(@"legajo", legajo);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void EliminarMateria(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE from MATERIAS WHERE ID_MATERIA = @id";
                command.Parameters.AddWithValue(@"id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<AlumnoBBDD> LeerAlumno()
        {
            List<AlumnoBBDD> alumnos = new List<AlumnoBBDD>();
            try
            {
                connection.Open();
                command.CommandText = "Select * from ALUMNOS";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int legajo = Convert.ToInt32(dataReader["LEGAJO"]);
                    string nombre = dataReader["NOMBRE"].ToString();
                    string apellido = dataReader["APELLIDO"].ToString();

                    string materia = "Aún no está inscripto";
                    if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 1)
                    {
                        materia = "Matemática";
                    }
                    if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 2)
                    {
                        materia = "Inglés";
                    }
                    if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 3)
                    {
                        materia = "Programación I";
                    }
                    if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 4)
                    {
                        materia = "Estadística";
                    }
                    if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 5)
                    {
                        materia = "Programacíón II";
                    }

                    string esta_activo = "No";
                    if (Convert.ToInt32(dataReader["ESTA_ACTIVO"]) == 1)
                    {
                        esta_activo = "Sí";
                    }

                    DateTime fecha = DateTime.Today;

                    if (dataReader["FECHA_INSCRIPCION"] is not null)
                    {
                        fecha = Convert.ToDateTime(dataReader["FECHA_INSCRIPCION"]);
                    }

                    float promedio = 0;
                    if (float.TryParse(dataReader["PROMEDIO"].ToString(), out float promedioAux))
                    {
                        promedio = promedioAux;
                    }

                    AlumnoBBDD nuevoalumno = new AlumnoBBDD(legajo, nombre, apellido, materia, esta_activo, fecha, promedio);

                    alumnos.Add(nuevoalumno);
                }
                return alumnos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<ProfesorBBDD> LeerProfesor()
        {
            List<ProfesorBBDD> lista = new List<ProfesorBBDD>();
            ProfesorBBDD profe = new ProfesorBBDD(1, "carlos", "carlitos", "materia1", 23.3F);
            lista.Add(profe);

            return lista;


            //List<ProfesorBBDD> profesores = new List<ProfesorBBDD>();
            //try
            //{
            //    connection.Open();
            //    command.CommandText = "Select * from PROFESORES";
            //    SqlDataReader dataReader = command.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        int legajo = Convert.ToInt32(dataReader["LEGAJO"]);
            //        string nombre = dataReader["NOMBRE"].ToString();
            //        string apellido = dataReader["APELLIDO"].ToString();

            //        string materia = "Aún no tiene asignación";
            //        if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 1)
            //        {
            //            materia = "Matemática";
            //        }
            //        if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 2)
            //        {
            //            materia = "Inglés";
            //        }
            //        if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 3)
            //        {
            //            materia = "Programación I";
            //        }
            //        if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 4)
            //        {
            //            materia = "Estadística";
            //        }
            //        if (Convert.ToInt32(dataReader["ID_MATERIA"]) == 5)
            //        {
            //            materia = "Programacíón II";
            //        }

            //        float sueldo = 0;
            //        if(float.TryParse(dataReader["SUELDO"].ToString(), out float sueldoAux))
            //        {
            //            sueldo = sueldoAux;
            //        }

            //        ProfesorBBDD nuevoProfesor = new ProfesorBBDD(legajo, nombre, apellido, materia, sueldo);

            //        profesores.Add(nuevoProfesor);
            //    }
            //    return profesores;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        public static List<AdminBBDD> LeerAdmin()
        {
            List<AdminBBDD> administradores = new List<AdminBBDD>();
            try
            {
                connection.Open();
                command.CommandText = "Select * from ADMINISTRADORES";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int legajo = Convert.ToInt32(dataReader["LEGAJO"]);
                    string nombre = dataReader["NOMBRE"].ToString();
                    string apellido = dataReader["APELLIDO"].ToString();


                    AdminBBDD nuevoAdmin = new AdminBBDD(legajo, nombre, apellido);

                    administradores.Add(nuevoAdmin);
                }
                return administradores;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<MateriaBBDD> LeerMateria()
        {
            List<MateriaBBDD> materias = new List<MateriaBBDD>();
            try
            {
                connection.Open();
                command.CommandText = "Select * from MATERIAS";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["ID_MATERIA"]);
                    string nombre = dataReader["NOMBRE_MATERIA"].ToString();
                    string cuatrimestre = dataReader["CUATRIMESTRE"].ToString();
                    string carrera = dataReader["CARRERA"].ToString();


                    MateriaBBDD nuevaMateria = new MateriaBBDD(id, nombre, cuatrimestre, carrera);

                    materias.Add(nuevaMateria);
                }
                return materias;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void GuardarAlumno(AlumnoBBDD alumno)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                //update articulos set precio=1000 where cantidad=10

                command.CommandText = $"UPDATE ALUMNOS set NOMBRE= @nombre, APELLIDO = @apellido, ID_MATERIA = @materia, ESTA_ACTIVO = @esta_activo WHERE LEGAJO = @legajo";
                command.Parameters.AddWithValue(@"legajo", alumno.Legajo);
                command.Parameters.AddWithValue(@"nombre", alumno.Nombre);
                command.Parameters.AddWithValue(@"apellido", alumno.Apellido);

                if (alumno.Materia == "Matemática")
                {
                    command.Parameters.AddWithValue(@"materia", 1);
                }
                if (alumno.Materia == "Inglés")
                {
                    command.Parameters.AddWithValue(@"materia", 2);
                }
                if (alumno.Materia == "Programación I")
                {
                    command.Parameters.AddWithValue(@"materia", 3);
                }
                if (alumno.Materia == "Estadística")
                {
                    command.Parameters.AddWithValue(@"materia", 4);
                }
                if (alumno.Materia == "Programación II")
                {
                    command.Parameters.AddWithValue(@"materia", 5);
                }
                if (alumno.Materia == "Programación III")
                {
                    command.Parameters.AddWithValue(@"materia", 6);
                }
                if (alumno.Materia == "Programación IV")
                {
                    command.Parameters.AddWithValue(@"materia", 7);
                }
                if (alumno.Materia == "Programación V")
                {
                    command.Parameters.AddWithValue(@"materia", 8);
                }

                if (alumno.Materia == "Programación VI")
                {
                    command.Parameters.AddWithValue(@"materia", 9);
                }

                if (alumno.Esta_activo == "Sí")
                {
                    command.Parameters.AddWithValue(@"esta_activo", 1);
                }
                else
                {
                    command.Parameters.AddWithValue(@"esta_activo", 0);
                }

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
