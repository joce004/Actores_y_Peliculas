using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Querys
{
    //Consultas SQL realizadas para el funcionamiento de la aplicación
    //Las contantes reciben los valores mediante la generación de una nueva string por String.Format
    public class Querys
    {

        public const string SELECT_GENEROS = "SELECT [Nombre] FROM [Peliculas_y_Actores].[dbo].[Genero]";

        public const string SELECT_PELICULA = "SELECT [Titulo] as 'Título', [Genero].[Nombre] as 'Genero', FORMAT ([Fecha_Estreno], 'yyyy-MM-dd') as 'Fecha de Estreno' FROM [Peliculas_y_Actores].[dbo].[Pelicula], [Peliculas_y_Actores].[dbo].[Genero] WHERE [Pelicula].[Genero] = [Genero].[ID];";
        public const string SELECT_PELICULA_F = "SELECT [Titulo] as 'Título', [Genero].[Nombre] as 'Genero', FORMAT ([Fecha_Estreno], 'yyyy-MM-dd') as 'Fecha de Estreno' FROM [Peliculas_y_Actores].[dbo].[Pelicula], [Peliculas_y_Actores].[dbo].[Genero] WHERE [Pelicula].[Genero] = [Genero].[ID] AND [{0}]  LIKE '%{1}%';";
        public const string SELECT_PELICULA_U = "SELECT [Titulo] as 'Título', [Genero].[Nombre] as 'Genero', FORMAT ([Fecha_Estreno], 'yyyy-MM-dd') as 'Fecha de Estreno' FROM [Peliculas_y_Actores].[dbo].[Pelicula], [Peliculas_y_Actores].[dbo].[Genero] WHERE [Pelicula].[Genero] = [Genero].[ID] AND [Pelicula].[Titulo] = '{0}';";
        public const string INSERT_PELICULA = "INSERT INTO [Peliculas_y_Actores].[dbo].[Pelicula] ([Titulo], [Genero], [Fecha_Estreno], [Foto]) VALUES('{0}', (SELECT[ID] FROM [Peliculas_y_Actores].[dbo].[Genero] WHERE[Nombre] = '{1}'), ({2}), '{3}')";
        public const string UPDATE_PELICULA = "UPDATE [Peliculas_y_Actores].[dbo].[Pelicula] SET [Titulo] = '{0}', [Genero] = (SELECT[ID] FROM [Peliculas_y_Actores].[dbo].[Genero] WHERE [Nombre] = '{1}'), [Fecha_Estreno] = ({2}), [Foto] = '{3}' WHERE  [Titulo] = '{4}'";
        public const string DELETE_PELICULA = "DELETE FROM [Peliculas_y_Actores].[dbo].[Pelicula] WHERE [Titulo] = '{0}';";

        public const string SELECT_TITULO = "SELECT [Titulo] as 'Título' FROM [Peliculas_y_Actores].[dbo].[Pelicula];";


        public const string SELECT_ACTOR = "SELECT [Nombre] as 'Nombre', [Sexo] as 'Sexo', FORMAT ([Fecha_Nacimiento], 'yyyy-MM-dd') as 'Fecha de nacimiento' FROM [Peliculas_y_Actores].[dbo].[ACTOR];";
        public const string SELECT_ACTOR_F = "SELECT [Nombre] as 'Título', [Sexo] as 'Sexo', FORMAT ([Fecha_Nacimiento], 'yyyy-MM-dd') as 'Fecha de nacimiento' FROM [Peliculas_y_Actores].[dbo].[ACTOR] WHERE  [{0}]  LIKE '%{1}%';";
        public const string SELECT_ACTOR_U = "SELECT [Nombre] as 'Título', [Sexo] as 'Sexo', FORMAT ([Fecha_Nacimiento], 'yyyy-MM-dd') as 'Fecha de nacimiento' FROM [Peliculas_y_Actores].[dbo].[ACTOR] WHERE [ACTOR].[Nombre] = '{0}';";
        public const string INSERT_ACTOR = "INSERT INTO [Peliculas_y_Actores].[dbo].[ACTOR] ([Nombre], [Sexo], [Fecha_Nacimiento], [Foto]) VALUES('{0}', '{1}', ({2}), '{3}')";
        public const string UPDATE_ACTOR = "UPDATE [Peliculas_y_Actores].[dbo].[ACTOR] SET [Nombre] = '{0}', [Sexo] =  '{1}', [Fecha_Nacimiento] = ({2}), [Foto] = '{3}' WHERE  [Nombre] = '{4}'";
        public const string DELETE_ACTOR = "DELETE FROM [Peliculas_y_Actores].[dbo].[ACTOR] WHERE [Nombre] = '{0}';";

        public const string SELECT_ACTOR_N = "SELECT [Nombre] as 'Nombre' FROM [Peliculas_y_Actores].[dbo].[ACTOR];";
        public const string SELECT_ELENCO = "SELECT [Nombre] as 'Nombre', [Sexo] as 'Sexo', FORMAT ([Fecha_Nacimiento], 'yyyy-MM-dd') as 'Fecha de nacimiento', [Pelicula].[Titulo] FROM [Peliculas_y_Actores].[dbo].[Pelicula], [Peliculas_y_Actores].[dbo].[ACTOR], [Peliculas_y_Actores].[dbo].[PeliculaActorR] WHERE [PeliculaActorR].[Pelicula] = [Pelicula].[ID] AND [Actor].[ID] = [PeliculaActorR].[Actor] AND [Pelicula].[Titulo] = '{0}'";
        public const string INSERT_ELENCO = "INSERT INTO [Peliculas_y_Actores].[dbo].[PeliculaActorR] ([Actor], [Pelicula]) VALUES((SELECT[ID] FROM [Peliculas_y_Actores].[dbo].[Actor] WHERE [Nombre] = '{0}'), (SELECT[ID] FROM [Peliculas_y_Actores].[dbo].[Pelicula] WHERE [Titulo] = '{1}'))";
        public const string DELETE_ELENCO = "DELETE FROM [Peliculas_y_Actores].[dbo].[PeliculaActorR] WHERE [Actor] = (SELECT[ID] FROM [Peliculas_y_Actores].[dbo].[Actor] WHERE [Nombre] = '{0}') AND [Pelicula] = (SELECT[ID] FROM [Peliculas_y_Actores].[dbo].[Pelicula] WHERE [Titulo] = '{1}')";

    }
}
