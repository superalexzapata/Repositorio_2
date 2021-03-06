using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    internal class CategoriaArchivo
    {
        public List<Categoria> listaCategorias;
        public void GenerarTxtCategorias()
        {
            string rutaCompleta = @"4-Categorias.csv";

            var unaCadenadeCategorias = new StringBuilder();

            // Build the users string.
            foreach (Categoria unCateg in listaCategorias)
            {
                unaCadenadeCategorias.Append(unCateg.Id2 +  ") ");
                //unaCadenadeCategorias.Append(";");
                unaCadenadeCategorias.Append(unCateg.NombreCategoria);
                unaCadenadeCategorias.Append(";");
                unaCadenadeCategorias.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeCategorias.ToString());
                mylogs.Close();
            }
        }
    }
}
